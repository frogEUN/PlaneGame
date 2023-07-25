using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{

    private Vector3 position;
    public float time;
    public GameObject gameobject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    


    private IEnumerator Timer()
    {
        while(true)
        {
            
            position = new Vector3(Random.Range(-2.7f, 2.7f), 5f, 0f);
            Instantiate<GameObject>(gameobject, position, Quaternion.identity);
            
            yield return new WaitForSeconds(time);
        }
    }
    
}
