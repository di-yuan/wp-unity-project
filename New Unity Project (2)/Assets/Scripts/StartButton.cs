using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour ,IPointerClickHandler{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData e)
    {
        record.A = 100;
        record.B = 100;
        record.C = 100;
        record.D = 100;
        record.E = 100;
        record.F = 100;
        record.G = 100;
        record.H = 100;

        SceneManager.LoadScene(1);
    }
}
