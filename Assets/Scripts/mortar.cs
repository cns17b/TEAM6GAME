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
    public Vector3 target;
    private int hit;
    private float speed;
    private float life; //timer for mortar

    // Start is called before the first frame update
    void Start()
    {
        hit = 0;
        speed = 200f;
        life = 20;
        rb = GetComponent<Rigidbody2D>();
        circ = GetComponent<CircleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        life = life - Time.deltaTime;

        //rb.velocity = new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
        transform.position = Mortar.transform.position;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Meteor")
        {
            hit = hit + 1;
            speed = 0;
            circ.radius = 2f;
            
            if (hit == 1)
            {
                Explosion.gameObject.SetActive(true);
                Explosion.transform.position = Mortar.transform.position;
                Mortar.gameObject.SetActive(false);
                life = 3f;
                explodesound.Play();
            }
        }
    }
}
