﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    // members or variables
    public float health = 3.0f;
    public float moveSpeed = 7.0f;
    public float score = 0.0f;


    public GameObject bulletspawner;
    public GameObject bullet;
    public GameObject textLife;
    public GameObject textScore;

    private Vector3 position;

    // methods or functions
    private void Start()
    {
       position = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update() {
        // Player movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.W))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 0, 0);
            //transform.getchild(0) LookAt();

        }// Player movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.A))
                transform.GetChild(0).rotation = Quaternion.Euler(0, -90, 0);
            //transform.getchild(0) LookAt();
        }// Player movement
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.S))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 180, 0);
            //transform.getchild(0) LookAt();
        }// Player movement
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.D))
                transform.GetChild(0).rotation = Quaternion.Euler(0, 90, 0);
            //transform.getchild(0) LookAt();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        textLife.GetComponent<Text>().text = health.ToString();
        textScore.GetComponent<Text>().text = score.ToString();
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            health -= 1.0f;
            transform.position = position;
            //transform.Translate(initial.position, Space.World);
            if (health < 0)
            {
                print("Player died!");
                // Destroy(this.gameobject);
            }
        }
   
    }
    void Shoot()
    {
        Instantiate(bullet.transform, bulletspawner.transform.position, bulletspawner.transform.rotation);
    }
}

