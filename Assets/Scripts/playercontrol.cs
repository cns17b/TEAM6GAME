using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontrol : MonoBehaviour
{
    public GameObject PlayerProjectile;
    public float speed;
    public float invincibletimer;
    public int hit;
    public float shots; //ammo counter
    public Text ammoText;
    public float ammotimer; //Timer to spawn an ammo pickup if player is out of ammo
    private bool hasShield;
    Rigidbody2D rb;
    AudioSource audioData;
    public Animator shieldanim; //shield animator
    public Animator anim; //Player animator
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject ammoPickup;

    // Start is called before the first frame update
    void Start()
    {
        hit = 0;
        shots = 6;
        rb = GetComponent<Rigidbody2D>();
        audioData = GetComponent<AudioSource>();
        speed = 30f;
        invincibletimer = 0;
        ammotimer = 3;
        hasShield = false;

        anim.SetBool("isMoving", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ammoText.text = "Ammo: " + shots.ToString();
        //Play Idle animation, and moving animation if moving
        invincibletimer = invincibletimer - Time.deltaTime;

        float move = Input.GetAxis("Vertical");

        if (move > 0.15)
        {
            //Debug.Log("pos");
            rb.velocity = new Vector2(rb.velocity.x, speed * move);
            anim.SetBool("isMoving", true);
        }
        else if (move < -0.15)
        {
            //Debug.Log("neg");
            rb.velocity = new Vector2(rb.velocity.x, speed * move);
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);

        }

        //End game when health is 0
        if (hit == 3)
        {

            rb.velocity = new Vector2(-5, rb.velocity.y);
            anim.SetBool("Dead", true);
            if (invincibletimer <= 0)
            {
                endgame();
            }
        } 

        //Fire Projectile is Space is pressed and there is ammo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("shoot");
            shoot();
        }
        //Spawn ammo if the player runs out
        if (shots <= 1)
        {
            ammotimer = ammotimer - Time.deltaTime;
            if (ammotimer < 0.1)
            {
                Vector2 position = new Vector2(50, Random.Range(-12, 12));
                Instantiate(ammoPickup, position, transform.rotation);
                ammotimer = 3;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (invincibletimer <= 0)
        {
            //Ignore the hit and diable shield if shield is active
            if(hasShield == true)
            {
                hasShield = false;
                shieldanim.SetBool("HasShield", false);
            }
            //Play hit sound and hit animation
            else if (col.gameObject.tag == "Meteor")
            {
                //Play Heath Loss animation (UI)
                hit = hit + 1;
                invincibletimer = 3;
                audioData.Play(0);
            }
            else if (col.gameObject.tag == "Enemy")
            {
                //Play Heath Loss animation (UI)
                hit = hit + 1;
                invincibletimer = 3;
                audioData.Play(0);
            }
            else if (col.gameObject.tag == "EnemyProjectile")
            {
                //Play Heath Loss animation (UI)
                hit = hit + 1;
                invincibletimer = 3;
                audioData.Play(0);
            }
        }
        //Give health if you get a health pickup and are not at full health
        if (col.gameObject.tag == "Health")
        {
            if (hit > 0)
            {
                hit = hit - 1;
            }
        }
        if (hit == 0)
        {
            health1.SetActive(true);
        }
        if (hit == 1)
        {
            health1.SetActive(false);
            health2.SetActive(true);
        }
        if (hit == 2)
        {
            health2.SetActive(false);
            health3.SetActive(true);
        }
        if (hit == 3)
        {
            health3.SetActive(false);
        }
        //Give shield if pick up a shield
        if (col.gameObject.tag == "Shield")
        {
            hasShield = true;
            shieldanim.SetBool("HasShield", true);
        }
        //Reset to max ammo if you pick up ammo
        if (col.gameObject.tag == "Ammo")
        {
            shots = 6;
            ammotimer = 3;
        }

    }
    void shoot()
    {
        if (shots > 0)
        { 
            Instantiate(PlayerProjectile, transform.position, transform.rotation);
            shots = shots - 1;         
        }
    }
    void endgame()
    {
      
       Time.timeScale = 0;
       Destroy(this.gameObject);
       

    }
}
