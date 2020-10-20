using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text goldAmountText;

    private int getAmountOfGold;

    public int GetAmountOfGold
    {
        get => getAmountOfGold;
        set => getAmountOfGold = GetComponentInParent<Gold>().goldAmount;
    }


    void Update()
    {
        this.goldAmountText.text = $"{this.getAmountOfGold} Gold";
    }
}
