using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortar : MonoBehaviour
{
    public ParticleSystem Explosion;
    public AudioSource explodesound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        Explosion.gameObject.SetActive(true);
        explodesound.Play();
    }
}
