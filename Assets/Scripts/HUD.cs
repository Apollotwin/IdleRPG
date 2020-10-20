using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text displayGold;
    private int displayAmountOfGold;

    void Start()
    {
        displayAmountOfGold = GetComponentInParent<Gold>().goldAmount;
    }

    void Update()
    {
        this.displayGold.text = $"{displayAmountOfGold} Gold";
    }

}