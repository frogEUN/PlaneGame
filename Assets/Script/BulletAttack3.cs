using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttack3 : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float attackSpeed;
    public float number;
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Wall"))
        {  // º®¿¡ ´êÀ¸¸é destroy
            Destroy(gameObject);
        }

        if(collision.collider.CompareTag("Enemy"))
        {  // Àû°ú ´êÀ¸¸é
            Destroy(gameObject);
            // ###### Àû Ã¼·Â ±ð±â
        }
    }

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (number == 1)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x + 0, player.transform.position.y + 0.7f, 0);
            rigid.AddForce(new Vector2(attackSpeed * 0, 0.7f * attackSpeed));
        }
        else if (number == 2)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x + 0.332f, player.transform.position.y + 0.601f, 0);
            rigid.AddForce(new Vector2(attackSpeed * 0.332f, 0.601f * attackSpeed));
        }
        else if (number == 3)
            rigid.AddForce(new Vector2(attackSpeed * 0.615f, 0.353f * attackSpeed));
        else if (number == 4)
            rigid.AddForce(new Vector2(attackSpeed * 0.7f, 0 * attackSpeed));
        else if (number == 5)
            rigid.AddForce(new Vector2(attackSpeed * 0.596f, -0.36f * attackSpeed));
        else if (number == 6)
            rigid.AddForce(new Vector2(attackSpeed * 0.337f, -0.61f * attackSpeed));
        else if (number == 7)
            rigid.AddForce(new Vector2(attackSpeed * 0, -0.7f * attackSpeed));
        else if (number == 8)
            rigid.AddForce(new Vector2(attackSpeed * -0.36f, -0.618f * attackSpeed));
        else if (number == 9)
            rigid.AddForce(new Vector2(attackSpeed * -0.601f, -0.373f * attackSpeed));
        else if (number == 10)
            rigid.AddForce(new Vector2(attackSpeed * -0.7f, 0 * attackSpeed));
        else if (number == 11)
            rigid.AddForce(new Vector2(attackSpeed * -0.623f, 0.333f * attackSpeed));
        else if (number == 12)
            rigid.AddForce(new Vector2(attackSpeed * -0.36f, 0.6f * attackSpeed));

        /*
        if (number==1)
            rigid.AddForce(new Vector2(attackSpeed* 0.0555965677f, 0.00260001421f * attackSpeed));
        else if (number==2)
            rigid.AddForce(new Vector2(attackSpeed*0.39359656f, 0.0913999677f*attackSpeed));
        else if (number==3)
            rigid.AddForce(new Vector2(attackSpeed* 0.66900003f, 0.342999995f * attackSpeed));
        else if (number==4)
            rigid.AddForce(new Vector2(attackSpeed * 0.755596578f, -0.697399974f * attackSpeed));
        else if (number == 5)
            rigid.AddForce(new Vector2(attackSpeed * 0.652999997f, -1.05400002f * attackSpeed));
        else if (number == 6)
            rigid.AddForce(new Vector2(attackSpeed * 0.393000007f, -1.30900002f * attackSpeed));
        else if (number == 7)
            rigid.AddForce(new Vector2(attackSpeed * 0.0555965677f, -1.3973999f * attackSpeed));
        else if (number == 8)
            rigid.AddForce(new Vector2(attackSpeed * -0.300000012f, -1.30900002f * attackSpeed));
        else if (number == 9)
            rigid.AddForce(new Vector2(attackSpeed * -0.546000004f, -1.06200004f * attackSpeed));
        else if (number == 10)
            rigid.AddForce(new Vector2(attackSpeed * -0.644403398f, -0.697399974f * attackSpeed));
        else if (number == 11)
            rigid.AddForce(new Vector2(attackSpeed * -0.56400001f, 0.360000014f * attackSpeed));
        else if (number == 12)
            rigid.AddForce(new Vector2(attackSpeed * -0.298999995f, 0.0920000002f * attackSpeed));
        */

    }
}
