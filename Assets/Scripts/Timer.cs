using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PunelOff;
    public Text text;
    public float TimeLeft;
    private float TimeYes;
    public Transform PointEnd;
    private int _count = 0;

    private void Update()
    {
        TimeLeft += Time.deltaTime;
        if (this.transform.position == PointEnd.position && _count == 0)
        {
            TimeYes = TimeLeft;
            _count++;
        }
        if (this.transform.position == PointEnd.position)
        {
            Panel.SetActive(true);
            PunelOff.SetActive(false);
            text.text = "Ваше время: " + Convert.ToString(TimeYes).Remove(6) + " сек.";
        }
        
    }
}
