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
            


    public void PlayButton ()
    {
        enemieS.SetActive(true);
        worlD.SetActive(false);
        
    }

    public void ExitButton ()
    {
        Application.Quit();
    }

}
