using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public int gold = 5;
    public Text goldDisplay;


    void Update()
    {
        goldDisplay.text = $"Gold: {gold}";
    }

}
