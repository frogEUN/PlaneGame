using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPlane : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y -1.7f, 0);
    }
}
