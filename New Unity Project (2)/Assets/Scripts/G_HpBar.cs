using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class G_HpBar : MonoBehaviour
{
    public Image G_hpBar;
    public float cost;
    void Start()
    {

    }

    void Update()
    {
        record.G -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        G_hpBar.fillAmount = record.G / 100;
    }
}