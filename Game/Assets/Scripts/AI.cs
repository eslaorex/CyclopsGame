using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public Transform player;
    public float playerDistance;
    public float rotationDampling;
    public float moveSpeed;
    public static bool isPlayerAlive = true;

    public bool isDamaging;
    public float damage = 10;


    void Update()
    {
        if (isPlayerAlive)
        {
            playerDistance = Vector3.Distance(player.position, transform.position);
            if (playerDistance < 15f)
            {
                LookAtPlayer();
            }
            if (playerDistance < 12f)
            {
                if (playerDistance > 2f)
                {
                    Chase();
                }
                else if (playerDistance < 2f)
                {
                    Attack();
                }
            }

        }
    }

    void LookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDampling);

    }

    void Chase()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void Attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                //hit.collider.gameObject.GetComponent<HealtScript>().health -= 5f;
            }
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
        }
    }

    void Score()
    {
        //SunScore.Add();
    }
}
