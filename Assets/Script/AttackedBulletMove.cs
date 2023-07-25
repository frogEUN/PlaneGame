using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackedBulletMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float bulletSpeed;
    private float rand;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rand = Random.Range(-0.3f, 0.3f);
    }

    void Update()
    {
        rigid.AddForce(new Vector3(rand, -1f, 0)*bulletSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }



}
