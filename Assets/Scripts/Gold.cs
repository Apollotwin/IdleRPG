using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    private int goldAmount;
    public Text goldAmountText;
    private int addFiveGold = 5;

    void Update()
    {
        this.goldAmountText.text = $"{goldAmount} Gold";
        
        if (Input.GetMouseButtonDown(0))
        {
            AddGold();
        }
          
    }

    void AddGold()
    {
        this.goldAmount += addFiveGold;
    }

}
