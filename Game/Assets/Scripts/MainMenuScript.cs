using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public GameObject enemieS;
    public GameObject worlD;
    public GameObject canvasScore;
    

 

    public void PlayButton () //Start the Game
    {
        enemieS.SetActive(true);
        worlD.SetActive(false);
        canvasScore.SetActive(true);
        //TODO: Activate main menu in Player Script
       
    }

    public void ExitButton ()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
