using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreButtons : MonoBehaviour
{
    public Button buyButton;
    public TextMeshProUGUI BuyButtonText;
    public int playerImageNum;
    public int neededGold;
    public TextMeshProUGUI textGold;

    private void Start()
    {
        StoreData.isHaveList[0] = true;
        textGold.text = neededGold + " Gold";
    }

    private void Update()
    {
        
        if (StoreData.isHaveList[playerImageNum])
        {
            buyButton.interactable = false;
            BuyButtonText.text = "HAVE";
        }
    }

    public void BuyButton()
    {
        if(!StoreData.isHaveList[playerImageNum])
        {
            if (GameData.gold >= neededGold)
            {
                buyButton.interactable = false;
                BuyButtonText.text = "HAVE";
                GameData.gold -= neededGold;
                StoreData.isHaveList[playerImageNum] = true;
            }
        }
        
    }

    public void UserButton()
    {
        if(StoreData.isHaveList[playerImageNum])
        {
            GameData.playerImage = playerImageNum;
        }
        
    }
}
