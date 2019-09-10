using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMove : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        a = GetComponent<Animator>();
        a.SetTrigger("Walk_01");
        rb = GetComponent<Rigidbody2D>();
        d = "r";
    }

    // Update is called once per frame
    void Update()
    {
        if (d == "r")
        {
            transform.position += Vector3.right * 0.02f;
            //rb.AddForce(Vector2.right * 0.5f);
            if (transform.position.x > edge_r)
            {
                transform.Rotate(0, 180, 0);
                d = "l";
            }
        }

        if (d == "l")
        {
            transform.position += Vector3.left * 0.02f;
            //rb.AddForce(Vector2.left * 0.5f);
            if (transform.position.x < edge_l)
            {
                transform.Rotate(0, 180, 0);
                d = "r";
            }
        }
    }

    Animator a;
    Rigidbody2D rb;
    string d;
    public float edge_l, edge_r;
}
