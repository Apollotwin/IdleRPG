using System;
using UnityEngine;
using UnityEngine.UI;

public class GoldPruducer : MonoBehaviour
{
    private GoldScript _goldScript;
    private float elapsedTime;
    public Text textbox;

    void Start()
    {
        _goldScript = FindObjectOfType<GoldScript>();
    }

    void FixedUpdate()
    {
        textbox.text = $"Small Gold Producer {Mathf.Round(elapsedTime)}";
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 5)
        {
            _goldScript.AddOneGold();
            elapsedTime = 0;
        }

    }
}
