using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D ballRb;
    [SerializeField]
    float ballForce = 10;
    float ballBounce = 10;
    private bool hitBorder;
    private bool hitplayer1;
    private bool hitplayer2;

    // Start is called before the first frame update
    void Start()
    {
        float startRandomRangeRight = Random.Range(50f, 100f);
        float startRandomRangeLeft = Random.Range(-50f, -100f);
        float startRandomRange = Random.Range(startRandomRangeLeft, startRandomRangeRight);
        ballRb = ballRb.gameObject.GetComponent<Rigidbody2D>();
        ballRb.AddForce(new Vector2(startRandomRange, 0)* ballForce);
    }

    // Update is called once per frame
    public void Update()
    {
        if(ballRb.velocity.x > 0 && hitBorder == true) 
        {
            ballRb.AddForce(Vector2.right * ballForce);
            
        }

        if (ballRb.velocity.x < 0 && hitBorder == true )
        {
            ballRb.AddForce(Vector2.left * ballForce);
        }

        if (gameObject.transform.position.y > 0 && hitBorder == true)
        {
            ballRb.AddForce(Vector2.down * ballBounce);
        }

        if (gameObject.transform.position.y < 0 && hitBorder == true)
        {
            ballRb.AddForce(Vector2.up* ballBounce);
        }

        if (hitplayer1 == true)
        {
            ballRb.AddForce(Vector2.right * ballBounce);
        }

        if (hitplayer2 == true)
        {
            ballRb.AddForce(Vector2.left * ballBounce);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Border"))
        {
            
            hitBorder = true;
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            hitplayer1 = true;
        }

        if (collision.gameObject.CompareTag("Player 2"))
        {

            hitplayer2 = true;
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {

            hitBorder = false;
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            hitplayer1 = false;
        }

        if (collision.gameObject.CompareTag("Player 2"))
        {

            hitplayer2 = false;
        }
    }

}
