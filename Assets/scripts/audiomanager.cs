using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class audiomanager : MonoBehaviour
{
    [Header("-----------------Audio Source----------------")]
   [SerializeField] AudioSource musicsource;
   [SerializeField] AudioSource SFXsource;

[Header("-----------------Audio Clip----------------")]
   public AudioClip background;
   public AudioClip scoreup;

    public AudioClip highscore;
    public AudioClip pipehit;
    public AudioClip gameover;
    public AudioClip click;
    public AudioClip hit;
    public AudioClip flap;

    public AudioClip bday;
    public AudioClip firework;
   
    
    private void Start(){
        musicsource.clip = background;
        musicsource.loop = true;
        musicsource.Play();
    }

    public void playSFX(AudioClip clip){
        SFXsource.PlayOneShot(clip);
    }

     public void playmusic(AudioClip clip){
        SFXsource.loop = true;
        SFXsource.PlayOneShot(clip);
    }
}
