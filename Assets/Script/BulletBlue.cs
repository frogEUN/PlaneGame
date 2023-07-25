using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBlue : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float attackSpeed;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigid.AddForce(new Vector2(0, attackSpeed));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
