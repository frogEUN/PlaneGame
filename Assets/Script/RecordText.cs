using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecordText : MonoBehaviour
{
    public TextMeshProUGUI recordShower;
    public TextMeshProUGUI goldShower;

    void Update()
    {
        if(GameData.isBest)
        {
            recordShower.text = "Your record : " + GameData.finishTime + " -> *BEST*";
        }
        else
        {
            recordShower.text = "Your record : " + GameData.finishTime;
        }
       
        goldShower.text = "You got " + GameData.currentGold + " Gold";
    }
}
