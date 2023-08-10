using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPlayer : MonoBehaviour
{
    public Transform ball;
    public float movementSpeed = 10;

    private void Update()
    {
        // Ensure the AI only moves when the ball is moving towards it
        if (ball.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            // Calculate the direction to the ball
            Vector3 direction = (ball.position - transform.position).normalized;

            // Move the AI paddle towards the ball's Y position
            Vector3 targetPosition = transform.position + new Vector3(0, direction.y, 0) * movementSpeed * Time.deltaTime;
            transform.position = targetPosition;
        }
    }
}

