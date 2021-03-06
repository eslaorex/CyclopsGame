﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public float speed;
    PlayerScript playerScript;
    GameObject player;
    public bool isPlayerAlive = true;

    private void Start()
    {
        player = GameObject.Find("PlayerCube");
        playerScript = player.GetComponent<PlayerScript>();
   
    }

    private void Update()
    {
        if (isPlayerAlive)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        }
            
    }


    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            DamagePlayer();
            DestroySelf();
            
        }
        
    }


    void DamagePlayer()
    {
        playerScript.DamagePlayer(1);
    }

    public void DestroySelf()
    {
        ScoreScript.scoreValue += 10;
        Destroy(gameObject);
        //TODO: explosion animation?

    }

 
 


}
