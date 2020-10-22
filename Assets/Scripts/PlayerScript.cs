using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int goldAmount;
    public GoldProducer goldProducer;
    
    public void Start()
    {
        goldProducer = FindObjectOfType<GoldProducer>();
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
            goldAmount++;
        }

    }

    public int GoldAmount
    {
        get => goldAmount;
        set => goldAmount = value;
    }

    public void BuyGoldProducer()
    {
        if (goldAmount >= goldProducer.GoldProducerCost)
        {
            Instantiate(goldProducer);
            goldAmount -= goldProducer.GoldProducerCost;
        }
        else
        {
            Debug.Log("Insufficiant gold");
        }
    }
    
}
