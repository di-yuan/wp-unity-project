using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class E_HpBar : MonoBehaviour
{
    public Image E_hpBar;
    public float cost;
    void Start()
    {

    }

    void Update()
    {
        record.E -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        E_hpBar.fillAmount = record.E / 100;
    }
}