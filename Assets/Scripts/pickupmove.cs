using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupmove : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
  
    // Start is called before the first frame update
    void Start()
    {
        speed = -1200f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);


    }
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

    }
    void end()
    {
        Destroy(this.gameObject);
    }
}
