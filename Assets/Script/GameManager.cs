using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverP;
    public GameObject[] enemyList = new GameObject[2];
    public TextMeshProUGUI showTime;

    public GameObject coin;



    private int currentRecord;

    public static GameManager instance;  // ╫л╠шео

    void Awake()
    {
        instance = this;  // ╫л╠шео
        GameData.hearts = 3;
        GameData.currentGold = 0;
        gameoverP.SetActive(false);
        Instantiate<GameObject>(enemyList[0], new Vector3(0, 3.17f, 0), Quaternion.identity);
        GameData.finishTime = 0;
        GameData.startTime = Time.time;
        GameData.isBest = false;
    }

    void Update()
    {
        if(GameData.hearts <= 0)
        {
            if(GameData.finishTime == 0)
            {
                currentRecord = (int)System.Math.Truncate((Time.time - GameData.startTime) / 1);
                GameData.finishTime = currentRecord;
            }
            if(currentRecord >= GameData.bestRecord)
            {
                GameData.bestRecord = currentRecord;
                GameData.isBest = true;
            }

            
            gameoverP.SetActive(true);
            GameData.isPlaying = false;
        }

        showTime.text = "" + System.Math.Truncate((Time.time - GameData.startTime) / 1);
    }

    public void CreateCoins()
    {
        for(var i=0; i<=10; i++)
        {
            Instantiate<GameObject>(coin, new Vector3(Random.Range(-2.7f, 2.7f), 5f, 0), Quaternion.identity);
        }
    }

    /*
    public void CreateNextEmpty(int index, float continueTime)
    {
        float time1 = Time.time;
        float time2 = Time.time;

        while(time2 <= time1 + continueTime)
        {
            time2 = Time.time;

        }
        Instantiate<GameObject>(enemyList[index], new Vector3(0, 3.17f, 0), Quaternion.identity);
    }*/

}
