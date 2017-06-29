using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {

    private Paddle paddle;

    private Vector3 paddleToBallVector;
    public Rigidbody2D rb;
    private bool hasStarted = false;
   

    void Start ()
    {

        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        
    }
	
	
	void Update ()
    {
        
        if (!hasStarted)
        {
            transform.position = paddle.transform.position + paddleToBallVector;
            
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            rb.velocity = new Vector2(2f, 10f);
        }
        
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
        AudioSource audio = GetComponent<AudioSource>();
        if (hasStarted)
        {
            
            audio.Play();
            rb.velocity += tweak;
        }
        else
        {
            print("noope");
        }
    }
}
