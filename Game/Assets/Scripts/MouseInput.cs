using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {

    EnemyAI enemy;
    public GameObject bullet;
    private float bulletSpeed = 6000f;
    private float bulletLife = 3f;


    public AudioClip laserSoundOne;
    public AudioClip laserSoundTwo;
    public AudioSource laserSounds;

    private void Start()
    {
        bullet = transform.Find("Bullet").gameObject;
        bullet.SetActive(false);
    }


    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
            FireSound();
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))

            {
                
                if (hit.rigidbody != null && hit.rigidbody.tag == "Enemy")
                { 
                Debug.Log("Clicked On: " + hit.rigidbody.name);
                hit.rigidbody.GetComponent<EnemyAI>().DestroySelf(); //Destroy Enemy 
                }
            }
            
          

        }


    }

    private void Fire()
    {

        GameObject bulletClone = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
        bulletClone.SetActive(true);

        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        rb.AddForce(-bullet.transform.forward * bulletSpeed);
        Destroy(bulletClone, bulletLife);

    }

    void FireSound()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.PlayOneShot(laserSoundOne);


    }

}
