using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    private Vector3 position;

    void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while(true)
        {
            position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
            Instantiate<GameObject>(bullet, position, Quaternion.identity);

            yield return new WaitForSeconds(0.5f);

        }
        
    }
}
