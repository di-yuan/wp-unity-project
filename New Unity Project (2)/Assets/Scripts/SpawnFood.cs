using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour {

	// Use this for initialization
	void Start () {
        time = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            //for (int i = 0; i < 3; i++)
            //{
                p = Random.Range(0, 14);
                x = Random.Range(-6, 6);
                y = Random.Range(-4, 4);
                Spawn(p, x, y);
            //}
            time = 2f;
        }
    }

    void Spawn(int p, float x, float y)
    {
        if (p == 1)
        {
            Transform f = Instantiate(a1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 2)
        {
            Transform f = Instantiate(a2_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 3)
        {
            Transform f = Instantiate(b1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 4)
        {
            Transform f = Instantiate(c1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);

        }
        if (p == 5)
        {
            Transform f = Instantiate(c2_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 6)
        {
            Transform f = Instantiate(d1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 7)
        {
            Transform f = Instantiate(d2_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 8)
        {
            Transform f = Instantiate(e1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 9)
        {
            Transform f = Instantiate(e2_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);

        }
        if (p == 10)
        {
            Transform f = Instantiate(f1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 11)
        {
            Transform f = Instantiate(f2_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 12)
        {
            Transform f = Instantiate(g1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 13)
        {
            Transform f = Instantiate(g2_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);
        }
        if (p == 14)
        {
            Transform f = Instantiate(h1_prefab);
            f.parent = transform;
            f.position = new Vector2(x, y);

        }
    }

    public Transform a1_prefab;
    public Transform a2_prefab;
    public Transform b1_prefab;
    public Transform c1_prefab;
    public Transform c2_prefab;
    public Transform d1_prefab;
    public Transform d2_prefab;
    public Transform e1_prefab;
    public Transform e2_prefab;
    public Transform f1_prefab;
    public Transform f2_prefab;
    public Transform g1_prefab;
    public Transform g2_prefab;
    public Transform h1_prefab;

    private int p;
    private float x, y;
    private float time;
}
