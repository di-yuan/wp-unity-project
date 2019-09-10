using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        original_y = transform.position.y;
        d = "u";
    }

    // Update is called once per frame
    void Update()
    {
        if (d == "u")
        {
            Debug.Log(transform.position.y);
            transform.position += Vector3.up * 0.005f;
            if (transform.position.y > (original_y + 0.03)) 
                d = "l";
        }

        if (d == "l")
        {
            Debug.Log(transform.position.y);
            transform.position += Vector3.down * 0.005f;
            if (transform.position.y < (original_y - 0.03))
                d = "u";
        }
    }

    string d;
    float original_y;
}
