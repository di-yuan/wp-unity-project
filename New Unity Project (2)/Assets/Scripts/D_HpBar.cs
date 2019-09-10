using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class D_HpBar : MonoBehaviour
{
    public Image D_hpBar;
    public float cost;
    void Start()
    {

    }

    void Update()
    {
        record.D -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        D_hpBar.fillAmount = record.D / 100;
    }
}