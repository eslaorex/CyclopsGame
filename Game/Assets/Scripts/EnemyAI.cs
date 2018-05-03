using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public float speed;
    PlayerScript playerScript;
    GameObject player;
    
    //ScoreScript scoreScript;
    //Sumscore sumScore;
    //ScoreScript scoreScript;
    //public GameObject otherGameObject;

    //public GameObject enemy;
    //public Transform enemyPos;
    //private float repeatRate = 0.2f;


    private void Start()
    {
        player = GameObject.Find("PlayerCube");
        playerScript = player.GetComponent<PlayerScript>();
      //  scoreScript = otherGameObject.GetComponent<ScoreScript>();
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }


    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            DamagePlayer();
            DestroySelf();
            //EnemySpawner();
        }
        
    }


    void DamagePlayer()
    {
        playerScript.DamagePlayer(1);
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    
        //TODO: Score add 10
    }

    /*
    void EnemySpawner()
    {
        InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
        Instantiate(enemy, enemyPos.position, enemyPos.rotation);
    }
    */
 


}
