using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.name == "Gordo")
        {
            //AudioSource.PlayClipAtPoint(pass_audio, transform.localPosition);
            SceneManager.LoadScene(page);
        }
    }

    public int page;
    //public AudioClip pass_audio;
}
