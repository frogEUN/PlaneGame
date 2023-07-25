using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBullet : MonoBehaviour
{
    Rigidbody2D rigid;
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
        if(collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

}
