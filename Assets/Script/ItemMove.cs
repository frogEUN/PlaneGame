using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigid.AddForce(new Vector3(0, -speed, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
            Destroy(gameObject);
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);

        }
    }
}
