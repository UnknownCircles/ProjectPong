using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEffects : MonoBehaviour
{
    public ParticleSystem collisionParticles;
    public AudioSource collisionSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            // Play particle effect
            if (collisionParticles != null)
            {
                collisionParticles.transform.position = collision.contacts[0].point;
                collisionParticles.Play();
            }

            // Play sound effect
            if (collisionSound != null)
            {
                collisionSound.Play();
            }

            // Other effects like screen shake, visual feedback, etc.
        }
    }
}
