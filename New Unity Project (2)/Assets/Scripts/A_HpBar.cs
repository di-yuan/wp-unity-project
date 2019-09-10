using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class A_HpBar : MonoBehaviour
{
    public Image A_hpBar;
    public float cost;
    void Start()
    {
       
    }

    void Update()
    {
        record.A -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        A_hpBar.fillAmount = record.A/ 100;
    }
}