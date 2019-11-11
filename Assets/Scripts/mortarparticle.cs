using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortarparticle : MonoBehaviour
{
    public ParticleSystem Explosion;
    public ParticleSystem mortar;
    public AudioSource explodesound;
    CircleCollider2D circ;
    public float life;
    private int hit;
    List<ParticleCollisionEvent> collisionEvents;
    // Start is called before the first frame update
    void Start()
    {
        circ = GetComponent<CircleCollider2D>();
        hit = 0;
        life = 50;
        collisionEvents = new List<ParticleCollisionEvent>();
        mortar.Emit(1);
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
        Explosion.transform.position = collisionEvents[1].intersection;
        circ.transform.position = collisionEvents[1].intersection;
        Explosion.Emit(1);
        life = 3f;
        mortar.Stop();
        explodesound.Play();

    }
}
