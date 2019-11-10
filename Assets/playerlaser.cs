using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlaser : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public ParticleSystem laser;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1500f;
        rb = GetComponent<Rigidbody2D>();
        laser.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Despawn")
        {
      
            Destroy(this.gameObject);
       
        }
    }
}
