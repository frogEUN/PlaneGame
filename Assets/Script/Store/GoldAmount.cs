using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldAmount : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "" + GameData.gold;
    }
}
