using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opengame : MonoBehaviour
{
    public void playgame(){
        SceneManager.LoadSceneAsync(1);
    }

    public void quitgame(){
        Application.Quit();
    }

    public void resetScore(){
        PlayerPrefs.SetInt("HighScore",0);
        PlayerPrefs.SetInt("watched",0);
    }
}
