using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool isItem1 = false;
    public float item1ContinueTime = 5f;
    public float item1BulletCreateTerm = 1f;
    private Vector3 position;
    public GameObject item1Bullet;
    public GameObject item2Bullet;
    public GameObject item3Bullet;
    public GameObject player;



    private Coroutine coroutine;

    public Sprite[] playerImageSet = new Sprite[5];

    void Start()
    {
        GameData.isPlaying = true;
        player.GetComponent<SpriteRenderer>().sprite = playerImageSet[GameData.playerImage];
    }

    void Update()
    {
        if(isItem1)
        {
            if(Time.time >= GameData.time + item1ContinueTime)
            {
                StopCoroutine(coroutine);
                isItem1 = false;
            }
                
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("EnemyBullet"))
        {
            if(GameData.isPlaying)
            {
                GameData.hearts -= 1;
            }  
        }
        if(collision.CompareTag("Item1"))
        {
            if(GameData.isPlaying)
            {
                GameData.time = Time.time;
                isItem1 = true;
                coroutine = StartCoroutine(Item1());
            }
        }
        if(collision.CompareTag("Item2"))
        {
            for(float x = -2.78f; x <= 2.84f; x += 0.28f)
            {
                position = new Vector3(x, -1.55f, 0);
                Instantiate<GameObject>(item2Bullet, position, Quaternion.identity);
            }
            
        }
        if(collision.CompareTag("Item3"))
        {
            position = new Vector3(player.transform.position.x, player.transform.position.y + 2f, 0);
            Instantiate<GameObject>(item3Bullet, position, Quaternion.identity);
        }
        
    }

    public IEnumerator Item1()
    {
        while(true)
        {
            
            position = new Vector3(player.transform.position.x + 0.5f, player.transform.position.y + 1f, 0);
            Instantiate<GameObject>(item1Bullet, position, Quaternion.identity);
            position = new Vector3(player.transform.position.x - 0.5f, player.transform.position.y + 1f, 0);
            Instantiate<GameObject>(item1Bullet, position, Quaternion.identity);
            yield return new WaitForSeconds(item1BulletCreateTerm);
        }

    }
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            GameData.hearts -= 1;
        }
    }

}
