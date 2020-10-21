using System;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private PlayerScript player;
    public Text DisplayAmountOfGold;

    private void Start()
    {
        player = FindObjectOfType<PlayerScript>();
    }

    private void Update()
    {
        var readAmountOfGold = player.GoldAmount;
        DisplayAmountOfGold.text = $"{readAmountOfGold} Gold";
    }
}