﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class meteormove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float powerup;
    public GameObject shield;
    public GameObject health;
    public GameObject ammo;
    public GameObject explosion;
    public AudioSource explodesound;
    

    // Start is called before the first frame update
    void Start()
    {
       
        speed = -1200f;
        rb = GetComponent<Rigidbody2D>();
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
            end();
       
        }

        if (col.gameObject.tag == "Player")
        {
            end();
        }
        if (col.gameObject.tag == "PlayerProjectile")
        {
            speed = 0;
            DropPowerup();
            explodesound.Play(0);
            Instantiate(explosion, transform.position, transform.rotation);
            end();
            //anim.SetBool("ifCrash", true);
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
        if (powerup == 1 ^ powerup == 20)
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