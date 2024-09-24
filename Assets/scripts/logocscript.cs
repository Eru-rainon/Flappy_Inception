using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logocscript : MonoBehaviour
{
   public int playerscore;
   public Text scoretext;
   public Text  HighScore;
   public audiomanager audiomanager;
   private bool hasHighScoreBeenBeaten = false;

   public GameObject gameoverscreen;
   

   void Start()
   {
      HighScore.text ="BEST: "+ PlayerPrefs.GetInt("HighScore",0).ToString();
      audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanager>();
      hasHighScoreBeenBeaten = false;
   }

   [ContextMenu("Increase Score")]  //adding controls to add score in the editor
   public void addscore(int score){
    playerscore+=score;
    scoretext.text = playerscore.ToString();

    

    if (playerscore >= 20 && PlayerPrefs.GetInt("watched",0) == 0){
      
          PlayerPrefs.SetInt("watched",1);
         SceneManager.LoadSceneAsync(2);
        
      
    }

    if(playerscore > PlayerPrefs.GetInt("HighScore",0)){
      PlayerPrefs.SetInt("HighScore",playerscore);
      HighScore.text = "BEST: "+PlayerPrefs.GetInt("HighScore",0).ToString();
      if(!hasHighScoreBeenBeaten){
         audiomanager.playSFX(audiomanager.highscore);
         hasHighScoreBeenBeaten = true;
      }
    }

   }

   public void restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    audiomanager.playSFX(audiomanager.click);
   }

   public void mainmenu(){
      SceneManager.LoadSceneAsync(0);
      audiomanager.playSFX(audiomanager.click);
   }

   public void gameover(){
        if(!gameoverscreen.activeSelf){
         gameoverscreen.SetActive(true);
        audiomanager.playSFX(audiomanager.gameover);
        }
        
   }
}
