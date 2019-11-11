using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    // Start is called before the first frame update
    private float life;
    void Start()
    {
        life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        life = life - Time.deltaTime;
        if(life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
