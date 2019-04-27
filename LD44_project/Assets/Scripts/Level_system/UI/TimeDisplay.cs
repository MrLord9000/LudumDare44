using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;
    private readonly int timer;  // time type?  

    public void Update()
    {
       timeText.text = " Time left : " + timer;
    }

    public void TimeLeft()
    {
        //counting 
    }
}
