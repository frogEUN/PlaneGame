using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowBestRecord : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {
        text.text = "Best Record : " + GameData.bestRecord;
    }

}
