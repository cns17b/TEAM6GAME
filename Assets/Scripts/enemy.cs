using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject EnemyProjectile;
    public float speed;
    private bool move;
    private bool shoot;
    private bool hit;
    //Time between shots
    public float shootDelay;
    public float shootTimer;
    public float movetimer;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        move = true;
        shoot = false;
        hit = false;
        movetimer = 1f;
        anim = GetComponent<Animator>();
        anim.SetBool("Start", true);
        shootDelay = 3;
        shootTimer = 1;
        speed = -25f;
        rb = GetComponent<Rigidbody2D>();
        anim.SetTrigger("Start");
        //Play the appearing animation that moves the cow onto the screen
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (move == false)
        {
            movetimer = movetimer - Time.deltaTime;
            if (movetimer <= 0)
            {
                
                speed = 0;
                rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
                anim.SetBool("Start", false);
            }
            
            shootTimer = shootTimer - Time.deltaTime;
        }
        if (hit == true)
        {
            speed = -2400f;
            rb.transform.Rotate(0, 0, (-speed / 6) * Time.deltaTime);
            rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
        }

        //Fire Projectile when timer is zero
        if (shootTimer <= 0)
        {
            if (shoot == true)
            {
                shootTimer = shootDelay;
                //Play shooting animation
                Instantiate(EnemyProjectile, transform.position, transform.rotation);
            }
            //anim.SetTrigger("Shoot");
        }
    }




    //Destroy enemy upon being hit
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerProjectile")
        {
            move = true;
            hit = true;
            shoot = false;
        }
        if (col.gameObject.tag == "Despawn")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        //Tell enemy when to stop moving and when to start shooting
        if (col.gameObject.tag == "StopEnemy")
        {
            move = false;
            shoot = true;
        }
    }

}
