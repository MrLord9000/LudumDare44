using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Coin : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private int coins;
    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        coins = 0;
    }

    void Update()
    {
        textMeshPro.SetText(coins.ToString());
        if (Input.GetKeyDown("c"))
        {
            coins++;
        }
    }
}
