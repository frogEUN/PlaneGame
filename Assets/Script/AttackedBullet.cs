using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AttackedBullet : MonoBehaviour
{
    private Vector3 position;
    public GameObject bullet;
    public float time = 1f;

    void Start()
    {
        StartCoroutine(Timer());
    }

    void Update()
    {
        
    }

    private IEnumerator Timer()
    {
        while(true)
        {
            position = new Vector3(Random.Range(-2.7f, 2.7f), 5f, 0f);
            Instantiate<GameObject>(bullet, position, Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
