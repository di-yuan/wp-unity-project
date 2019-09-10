using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(record.A <= 0 || record.B <= 0 || record.C <= 0 || record.D <= 0 || record.E <= 0 || record.F <= 0 || record.G <= 0 || record.H <= 0)
        {
             SceneManager.LoadScene(4);
            
        }
    }
    
}
