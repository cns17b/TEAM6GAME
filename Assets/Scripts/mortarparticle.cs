using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortarparticle : MonoBehaviour
{
    public GameObject Explosion;
    public ParticleSystem mortar;
    public AudioSource explodesound;
    public float life;
    private int hit;
    List<ParticleCollisionEvent> collisionEvents;
    // Start is called before the first frame update
    void Start()
    {
        hit = 0;
        life = 50;
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        life = life - Time.deltaTime;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnParticleCollision(GameObject other)
    {
        ParticlePhysicsExtensions.GetCollisionEvents(mortar, other, collisionEvents);
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Meteor")
        {
            print(hit);
            hit = hit + 1;
            if (hit == 1)
            {
                Instantiate(Explosion);
                Explosion.transform.position = collisionEvents[1].intersection;
                life = 3;
                this.gameObject.SetActive(false);
                explodesound.Play();
            }
        }

    }
}
