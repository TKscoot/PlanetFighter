using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float topSpeed = 10f;
    
    bool facingRight = true;            // player facing direction

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");       //get move direction

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if(move > 0 && !facingRight)
        {
            ChangeFacing();
        }
        else if(move < 0 && facingRight)
        {
            ChangeFacing();
        }
    }

    void ChangeFacing()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;

        theScale.x *= -1;

        transform.localScale = theScale;
    }
}
