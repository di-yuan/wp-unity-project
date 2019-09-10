using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        d = "r";
    }
	
	// Update is called once per frame
	void Update () {
        if (d == "r")
        {
            rb.AddForce(Vector2.right * 5);
            if (transform.position.x > edge_r)
            {
                transform.Rotate(0, 180, 0);
                d = "l";
            }            
        }

        if (d == "l") 
        {
            rb.AddForce(Vector2.left * 5);
            if (transform.position.x < edge_l)
            {
                transform.Rotate(0, 180, 0);
                d = "r";
            }
        }     
    }

    Rigidbody2D rb;
    string d;
    public float edge_l, edge_r;
}
