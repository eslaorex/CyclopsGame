using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //TODO Check hits, if 0 game over Health script
    //TODO Score UI

    [SerializeField]
    int playerHits;


	// Use this for initialization
	void Start () {
        playerHits = 3;
	}
	
	
	public void DamagePlayer (int damage)
    {
        playerHits -= damage;
        

        if (playerHits <= 0)
        {
            GameOver();
        }
	}

    void GameOver ()
    {
        Debug.Log("Game Over!");
        Destroy(gameObject);
        //TODO: Visa gameOver menu
        //TODO: Sluta pwana fiender


    }
}
