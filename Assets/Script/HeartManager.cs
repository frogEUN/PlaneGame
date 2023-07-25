using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManager : MonoBehaviour
{
    public int number;
    public Sprite[] images = new Sprite[2];

    void Start()
    {
        
    }

    void Update()
    {
        if(GameData.hearts >= number)
            gameObject.GetComponent<SpriteRenderer>().sprite = images[1];
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = images[0];
    }
}
