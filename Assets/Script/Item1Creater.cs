using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1Creater : MonoBehaviour
{
    public float item1CreateTerm;
    private Vector3 position;
    public GameObject gameobject;


    void Start()
    {
        StartCoroutine(Creater());
    }

    public IEnumerator Creater()
    {
        while(true)
        {
            yield return new WaitForSeconds(item1CreateTerm);
            position = new Vector3(Random.Range(-2.7f, 2.7f), 5f, 0f);
            Instantiate<GameObject>(gameobject, position, Quaternion.identity);


            
        }
    }
}
