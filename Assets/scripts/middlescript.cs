using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlescript : MonoBehaviour
{

    public logocscript logic;
    public audiomanager audiomanager;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logocscript>();
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanager>();
    }

  
    

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.layer == 3){
            logic.addscore(2);
            audiomanager.playSFX(audiomanager.scoreup);
        }
        
    }
}
