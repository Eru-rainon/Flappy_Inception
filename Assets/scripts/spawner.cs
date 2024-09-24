using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2f;
    private float timer = 0f;
    

    public float heightoffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate){
            timer += Time.deltaTime;
        }
        else{
            spawnpipe();
            timer = 0;
        }
        
    }

    void spawnpipe()
    {
            float lowestpoint  = transform.position.y - heightoffset;
            float highespoint = transform.position.y + heightoffset;
             Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint,highespoint),0), transform.rotation);
    }
}
