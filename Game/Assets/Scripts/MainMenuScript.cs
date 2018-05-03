using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

    public GameObject enemieS;
    public GameObject worlD;
    //SumScoreManager sumScoreManager;

    private void Start()
    {
        //sumScoreManager = sumScore.GetComponent<SumScoreManager>();
    }
            


    public void PlayButton () //Start the Game
    {
        enemieS.SetActive(true);
        worlD.SetActive(false);
        //TODO: Activate main menu in Player Script

    }

    public void ExitButton ()
    {
        Application.Quit();
    }

}
