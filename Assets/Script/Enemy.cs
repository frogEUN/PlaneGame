using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    public float moveSpeed;
    public float minX;
    public float maxX;
    private Coroutine coroutine;
    public GameObject bullet;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("PlayerBullet"))
        {
            hp -= 1;
        }
        if(collision.collider.CompareTag("PlayerBullet3"))
        {
            hp -= 10;
        }
            
    }


    // Start is called before the first frame update
    void Start()
    {
        coroutine = StartCoroutine(Creater());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveSpeed*Time.deltaTime, 0, 0);
        if (transform.position.x <= minX || transform.position.x >= maxX)
        {
            moveSpeed *= -1;
        }

        if (hp <= 0)
        {
            GameData.enemyIndex += 1;
            if(GameData.enemyIndex >= GameManager.instance.enemyList.Length)
            {
                GameData.enemyIndex -= GameManager.instance.enemyList.Length;
            }
            StopCoroutine(coroutine);
            GameManager.instance.CreateCoins();
            Destroy(gameObject);
            Instantiate<GameObject>(GameManager.instance.enemyList[GameData.enemyIndex], new Vector3(0, 3.17f, 0), Quaternion.identity);
        }
            
    }



    IEnumerator Creater()
    {
        while(true)
        {
            Instantiate<GameObject>(bullet, new Vector3(transform.position.x, transform.position.y - 1.72f, 0), Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }
    }
    
}
