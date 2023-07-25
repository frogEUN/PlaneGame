using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpBtn : MonoBehaviour
{
    public bool click;
    public GameObject player;
    public float moveSpeed = 1f;

   
    void Update()
    {
        if(click)
        {
            player.transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
        }
    }

    public void PointerDown()
    {
        click = true;
    }

    public void PointerUP()
    {
        click = false;
    }
}
