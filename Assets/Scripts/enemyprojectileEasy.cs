using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyprojectileEasy : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public Vector3 target;
    private bool movetowards;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        speed = 1200f;
        rb = GetComponent<Rigidbody2D>();
        movetowards = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movetowards == true)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else
        {
            rb.velocity = new Vector2(-speed*Time.deltaTime, rb.velocity.y);
        }
    }

    //Play Hit animation and despawn at hit
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            speed = 0;
            anim.SetTrigger("Hit");
            end();

        }
        if (col.gameObject.tag == "Despawn")
        {
            end();
        }
        if (col.gameObject.tag == "StopMove")
        {
            speed = 1200;
            movetowards = false;
        }
    }
    void end()
    {
        Destroy(this.gameObject);
    }
}
