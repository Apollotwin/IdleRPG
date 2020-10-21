using System;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public int goldAmount;
    public Text goldAmountText;
    private int addFiveGold = 5;

    public void Start()
    {
        goldAmount = PlayerPrefs.GetInt("Gold", 0);
    }

    public void OnDestroy()
    {
        PlayerPrefs.SetInt("Gold", goldAmount);
    }

    void Update()
    {
        goldAmountText.text = $"{goldAmount} Gold";
        
        if (Input.GetMouseButtonDown(0))
        {
            AddGold();
        }
          
    }

    void AddGold()
    {
        goldAmount += addFiveGold;
    }

}
