using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour {
    [SerializeField]
    Transform planet;
    [SerializeField]
    float gravity = 20f;
    private Rigidbody2D rb;

	// Use this for initialization
	public void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector2 difference = planet.transform.position - this.transform.position;
        rb.AddForce((difference).normalized * gravity);
        float angle = Mathf.Atan2(difference.x, difference.y);
        this.transform.rotation = Quaternion.AngleAxis(angle, transform.up);
	}

    public void Attract(Rigidbody2D body)
    {
    }
}
