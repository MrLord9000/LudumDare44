using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public Text goldText;
    private int gold = 0;

    public void Update()
    {
        goldText.text = " Gold : " + gold;
    }

    public void CatchGold()
    {
        gold += 1;
    }

    public void LoseGold()
    {
        gold -= 1;
    }
}
