using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class H_HpBar : MonoBehaviour
{
    public Image H_hpBar;
    public float cost;
    void Start()
    {

    }

    void Update()
    {
        record.H -= Time.deltaTime * cost;
        updateHPBar();
    }

    void updateHPBar()
    {
        H_hpBar.fillAmount = record.H / 100;
    }
}