using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item3Creater : MonoBehaviour
{
    public GameObject item3;
    public float item3CreateTerm;
    private Vector3 position;


    void Start()
    {
        StartCoroutine(Creater());
    }

    IEnumerator Creater()
    {
        while(true)
        {
            yield return new WaitForSeconds(item3CreateTerm);
            position = new Vector3(Random.Range(-2.7f, 2.7f), 5f, 0);
            Instantiate<GameObject>(item3, position, Quaternion.identity);
            
        }
    }
}
