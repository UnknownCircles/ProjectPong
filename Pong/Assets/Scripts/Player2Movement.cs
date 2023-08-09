using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [SerializeField] private float speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
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
