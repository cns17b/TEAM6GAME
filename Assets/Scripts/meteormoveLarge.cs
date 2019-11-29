using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class meteormoveLarge : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float powerup;
    private int hit;
    public GameObject shield;
    public GameObject health;
    public GameObject ammo;
    public GameObject explosion;
    public AudioSource explodesound;
    GameObject[] holes;


    // Start is called before the first frame update
    void Start()
    {
       

        speed = -1200f;
        rb = GetComponent<Rigidbody2D>();
        hit = 0;
        holes = GameObject.FindGameObjectsWithTag("Hole");
        foreach (GameObject g in holes)
        {
            g.SetActive(false);
        }
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
            hit = hit + 2;
            if (hit == 2)
            {
                end();
            }
        }

        if (col.gameObject.tag == "Player")
        {
            hit = hit + 2;
            if (hit == 2)
            {
                end();
            }
        }
        if (col.gameObject.tag == "PlayerProjectile")
        {
            hit = hit + 1;

                foreach (GameObject g in holes)
                {
                    g.SetActive(true);
                }

            if (hit == 2)
            {
                speed = 0;
                DropPowerup();
                explodesound.Play(0);
                Instantiate(explosion, transform.position, transform.rotation);
                end();
            }
           
        }
    }

    void end()
    {
        
        Destroy(this.gameObject);
    }

    void DropPowerup()
    {
        powerup = Random.Range(1, 15);
        //Spawn health  
        if (powerup == 1)
        {
            Instantiate(health, transform.position, transform.rotation);
        }
        //Spawn shield 
        else if (powerup == 2 ^ powerup == 3)
        {
            Instantiate(shield, transform.position, transform.rotation);
        }
        //Spawn ammo
        else if (powerup == 4 ^ powerup == 5 ^ powerup == 6)
        {
            Instantiate(ammo, transform.position, transform.rotation);
        }
    }
}