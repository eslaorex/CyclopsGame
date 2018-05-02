using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {

    EnemyAI enemy;


    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))

            {
                if (hit.rigidbody != null && hit.rigidbody.tag == "Enemy")
                { 
                Debug.Log("Clicked On: " + hit.rigidbody.name);
                //TODO: destroy Enemy

                hit.rigidbody.GetComponent<EnemyAI>().DestroySelf();
                }
            }


        }


    }
}
