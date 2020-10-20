using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public int gold = 0;

    public Text goldDisplay;

    // Update is called once per frame
    void Update()
    {
        this.goldDisplay.text = $"Gold: {gold}";
    }
}
