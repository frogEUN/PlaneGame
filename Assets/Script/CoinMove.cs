using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float coinSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(new Vector3(0, -coinSpeed, 0));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
            Destroy(gameObject);
        else if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (GameData.isPlaying)
            {
                GameData.gold += 1;
                GameData.currentGold += 1;
            }
                
        }
    }

}
