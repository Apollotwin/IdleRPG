using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGold : MonoBehaviour
{
    public int goldIncreaseBy = 0;
    public HUD assignHud;

    public void DoAddGold()
    {
        assignHud.gold = goldIncreaseBy + assignHud.gold;
    }
}
