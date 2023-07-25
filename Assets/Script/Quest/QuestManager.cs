using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public bool[] isCleared = new bool[7];
    public Button[] rewardButtons = new Button[7];
    public static QuestManager instance;

    void Start()
    {
        instance = this;
        for (int i = 0; i < isCleared.Length; i++)
        {
            isCleared[i] = false;
        }
    }

    void Update()
    {
        for (int i = 1; i < isCleared.Length; i++)
        {
            if (isCleared[i])
            {
                rewardButtons[i].interactable = false;
            }
        }
    }
}
