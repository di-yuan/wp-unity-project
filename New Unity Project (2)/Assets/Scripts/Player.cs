using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
        at = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        d = "r";
    }
	
	// Update is called once per frame
	void Update () {

        at.SetFloat("v", 0f);
        at.SetBool("jump", false);
        at.SetBool("hit", false);
        hit = false;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (d == "r")
                transform.Rotate(0, 180, 0);
            rb.AddForce(Vector2.left * 5);
            at.SetFloat("v", 10);
            d ="l";
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (d == "l")
                transform.Rotate(0, 180, 0);
            rb.AddForce(Vector2.right * 5);
            at.SetFloat("v", 10);
            d = "r";
        }

        if (Input.GetKey(KeyCode.Space))
        {
            at.SetBool("jump", true);
            transform.position += Vector3.up * 0.15f;
        }

        if (Input.GetKey(KeyCode.C))
        {
            AudioSource.PlayClipAtPoint(hit_audio, transform.localPosition);
            at.SetBool("hit", true);
            hit = true;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.parent.name == "monster") 
        {
            AudioSource.PlayClipAtPoint(hurt_audio, transform.localPosition);
            if (hit)
                Destroy(collision.gameObject);
            Debug.Log("SS");
            p = Random.Range(0, 8);
            x1 = Random.Range(15, 20);
            for (int i = 0; i < 3; i++)
                decreaseRandom(p, x1);
        }

        if (collision.transform.parent.name == "food")
        {
            AudioSource.PlayClipAtPoint(eat_audio, transform.localPosition);
            Destroy(collision.gameObject);
            x2 = Random.Range(10, 15);
            if (collision.transform.name == "a1(Clone)" || collision.transform.name == "a2(Clone)")
                record.A += x2;
            if (collision.transform.name == "b1(Clone)")
                record.B += x2;
            if (collision.transform.name == "c1(Clone)" || collision.transform.name == "c2(Clone)")
                record.C += x2;
            if (collision.transform.name == "d1(Clone)" || collision.transform.name == "d2(Clone)")
                record.D += x2;
            if (collision.transform.name == "e1(Clone)" || collision.transform.name == "e2(Clone)")
                record.E += x2;
            if (collision.transform.name == "f1(Clone)" || collision.transform.name == "f2(Clone)")
                record.F += x2;
            if (collision.transform.name == "g1(Clone)" || collision.transform.name == "g2(Clone)")
                record.G += x2;
            if (collision.transform.name == "h1(Clone)")
                record.H += x2;
        }
    }

    void decreaseRandom(int p, int x)
    {
        if (p == 1)
            record.A -= x;
        if (p == 2)
            record.B -= x;
        if (p == 3)
            record.C -= x;
        if (p == 4)
            record.D -= x;
        if (p == 5)
            record.E -= x;
        if (p == 6)
            record.F -= x;
        if (p == 7)
            record.G -= x;
        if (p == 8)
            record.H -= x;
    }
    
    Animator at;
    Rigidbody2D rb;
    string d;
    bool hit;
    private int p, x1, x2;
    public AudioClip eat_audio;
    public AudioClip hit_audio;
    public AudioClip hurt_audio;
}
