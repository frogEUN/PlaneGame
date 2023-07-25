using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardButton : MonoBehaviour
{
    public int rewardGold;
    public int questIndex;
    public int questRecord;

    public void GetReward()
    {
        if(GameData.bestRecord >= questRecord)
        {
            GameData.gold += rewardGold;
            QuestManager.instance.isCleared[questIndex] = true;
        }
        
    }
}
