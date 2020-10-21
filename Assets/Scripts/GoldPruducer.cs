using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldPruducer : MonoBehaviour
{
    private GoldScript _goldScript;
    private float timeStart = 5;
    public Text textbox;
    
    void Start()
    {
        _goldScript = FindObjectOfType<GoldScript>();

    }
    void Update()
    {
        textbox.text = $"Small Gold Producer {Mathf.Round(timeStart).ToString()}";

        if (timeStart >= 0 && timeStart <= 5 )
        {
            timeStart -= Time.deltaTime;
        }
        else
        {
            timeStart = 5;
            _goldScript.AddOneGold();
        }
    }
}
