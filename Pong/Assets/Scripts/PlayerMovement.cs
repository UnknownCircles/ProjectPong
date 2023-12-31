using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 7;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        if (gameObject.transform.position.y > 4f)
        {
            gameObject.transform.position = new Vector2(transform.position.x, 4f);
        }

        if (gameObject.transform.position.y < -4f)
        {
            gameObject.transform.position = new Vector2(transform.position.x, -4f);


        }
    }
}
