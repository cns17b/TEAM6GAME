﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class meteormoveLarge : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float powerup;
    public GameObject shield;
    public GameObject health;
    public GameObject ammo;
    public Animator anim;
    private int hit;
    

    // Start is called before the first frame update
    void Start()
    {
       
        anim = GetComponent<Animator>();
        speed = -1200f;
        rb = GetComponent<Rigidbody2D>();
        hit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
        rb.transform.Rotate(0, 0, 100 * Time.deltaTime);
       
    }

    //Destroy Meteor if hit
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Despawn")
        {
            hit = hit + 1;
            if (hit == 2)
            {
                end();
            }
        }

        if (col.gameObject.tag == "Player")
        {
            hit = hit + 1;
            if (hit == 2)
            {
                end();
            }
        }
        if (col.gameObject.tag == "PlayerProjectile")
        {
            hit = hit + 1;
            if (hit == 2)
            {
                speed = 0;
                DropPowerup();
                anim.SetBool("ifCrash", true);
            }
           
        }
    }

    void end()
    {
        
        Destroy(this.gameObject);
    }

    void DropPowerup()
    {
        powerup = Random.Range(1, 20);
        //Spawn health 5% of the time
        if (powerup == 1)
        {
            Instantiate(health, transform.position, transform.rotation);
        }
        //Spawn shield 10% of the time
        else if (powerup == 2 ^ powerup == 3)
        {
            Instantiate(shield, transform.position, transform.rotation);
        }
        //Spawn ammo 15% of the time
        else if (powerup == 4 ^ powerup == 5 ^ powerup == 6)
        {
            Instantiate(ammo, transform.position, transform.rotation);
        }
    }
}