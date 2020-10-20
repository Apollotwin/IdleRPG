using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int goldAmount;
    private int addFiveGold = 5;

    void Update()
    {
          AddGold();
    }

    void AddGold()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.goldAmount += addFiveGold;
        }
    }

}
