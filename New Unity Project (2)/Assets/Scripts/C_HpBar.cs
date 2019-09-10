using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class C_HpBar : MonoBehaviour
{
    public Image C_hpBar;
    public float cost;
    void Start()
    {
     
    }

    void Update()
    {
        record.C -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        C_hpBar.fillAmount = record.C / 100;
    }
}