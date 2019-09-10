using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class F_HpBar : MonoBehaviour
{
    public Image F_hpBar;
    public float cost;
    void Start()
    {

    }

    void Update()
    {
        record.F -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        F_hpBar.fillAmount = record.F / 100;
    }
}