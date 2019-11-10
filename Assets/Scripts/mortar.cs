using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortar : MonoBehaviour
{
    Rigidbody2D rb;
    CircleCollider2D circ;
    public ParticleSystem Explosion;
    public AudioSource explodesound;
    public ParticleSystem Mortar;
    private float speedx;
    private float speedy;
    private float life; //timer for mortar

    // Start is called before the first frame update
    void Start()
    {
        speedx = 200;
        speedy = 100;
        life = 50;
        rb = GetComponent<Rigidbody2D>();
        circ = GetComponent<CircleCollider2D>();
      

    }

    // Update is called once per frame
    void Update()
    {
        life = life - Time.deltaTime;
        rb.velocity = new Vector2(speedx * Time.deltaTime, speedy * Time.deltaTime);
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Meteor")
        {
            speedx = 0;
           
            rb.gravityScale = 0;
            circ.radius = 2f;
            Mortar.gameObject.SetActive(false);
            Explosion.gameObject.SetActive(true);
            life = 3f;
            explodesound.Play();
        }
    }
}
