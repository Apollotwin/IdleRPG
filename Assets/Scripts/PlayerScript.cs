using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int goldAmount;
    private List<int> goldProducers = new List<int>();
    private GoldScript _goldScript;
    
    
    public void Start()
    {
        _goldScript = FindObjectOfType<GoldScript>();
        goldAmount = PlayerPrefs.GetInt("Gold", 0);
    }

    public void OnDestroy()
    {
        PlayerPrefs.SetInt("Gold", goldAmount);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _goldScript.AddOneGold();
        }

    }

    public int GoldAmount
    {
        get => goldAmount;
        set => goldAmount = value;
    }
}
