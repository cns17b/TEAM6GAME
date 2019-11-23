using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineMove : MonoBehaviour
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
    void Update()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
    }
}
