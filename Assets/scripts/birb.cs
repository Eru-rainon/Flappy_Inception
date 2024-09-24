using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birb : MonoBehaviour
{
    public Rigidbody2D Bird;
    public float flapstrength = 15f;
    public logocscript logic;
    private bool skill = true;
    private bool gamenotover;
    public audiomanager audiomanager;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logocscript>();
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanager>();
        skill = true;
        gamenotover = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(skill){
            if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
                audiomanager.playSFX(audiomanager.flap);
                Bird.velocity = Vector2.up * flapstrength;
        }
        }

        if(transform.position.y < -6 || transform.position.y > 6){
            skill = false;
            logic.gameover();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        skill = false;
        Debug.Log("dead");
        if(gamenotover){
            logic.gameover();
            gamenotover =false;
        }
        
        audiomanager.playSFX(audiomanager.hit);
        
    }
}
