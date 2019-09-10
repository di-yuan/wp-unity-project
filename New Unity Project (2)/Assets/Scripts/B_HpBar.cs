using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class B_HpBar : MonoBehaviour
{
    public Image B_hpBar;
    public float cost;
    void Start()
    {
        
    }

    void Update()
    {
        record.B -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        B_hpBar.fillAmount = record.B / 100;
    }
}