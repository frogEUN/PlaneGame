using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMP : MonoBehaviour
{
    float start;

    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(start + 5 <Time.time)
        {
            Destroy(gameObject);
        }
    }
}
