using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2Creater : MonoBehaviour
{
    public GameObject item2;
    public float item2CreateTerm;
    private Vector3 position;

    void Start()
    {
        StartCoroutine(Creater());
    }

    IEnumerator Creater()
    {
        while(true)
        {
            yield return new WaitForSeconds(item2CreateTerm);
            position = new Vector3(Random.Range(-2.7f, 2.7f), 5f, 0);
            Instantiate<GameObject>(item2, position, Quaternion.identity);

            
        }
    }
}
