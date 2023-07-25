using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    public Rigidbody2D rigid;
    float x, y;
    public float moveSpeed;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);

        Vector2 direction = new Vector2(x, y).normalized;
        rigid.AddForce(direction*moveSpeed);
    }

}
