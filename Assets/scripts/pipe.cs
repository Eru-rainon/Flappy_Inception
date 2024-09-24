using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float movespeed = 5f;
    public float deadzone = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed)* Time.deltaTime;
        if(transform.position.x < deadzone){
            Destroy(gameObject);
        }
    }
}
