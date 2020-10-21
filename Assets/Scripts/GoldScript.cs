using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UIElements.Button;

public class GoldScript : MonoBehaviour
{
    private int goldValue = 1;
    private PlayerScript player;

    private void Start()
    {
        player = FindObjectOfType<PlayerScript>();
    }
    
    public int AddOneGold()
    {
        player.GoldAmount += goldValue;
        return player.GoldAmount;
    }
    
}
