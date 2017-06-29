using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Brick : MonoBehaviour {

    public static int breakableCount = 0;
    private LevelManager levelmanager;
    public int Maxhits;
    private int timesHit;
    public Sprite[] hitSprites;
    private bool isBreakable;
    //public AudioSource thatcrack;
    public AudioClip clip;
    
   
    


    // Use this for initialization
    void Start ()
    {
        //clip = GameObject.FindObjectOfType<AudioClip>();
       levelmanager = GameObject.FindObjectOfType<LevelManager>();
        isBreakable = (this.tag == "Breakable");
        timesHit = 0;
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }
	}

    void OnCollisionExit2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position, 0.8f);


        if (isBreakable)
        {
            HandleHits();
        }

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //thatcrack = GetComponent<AudioSource>();
        
        //AudioSource crack = GetComponent<AudioSource>();
        //crack.Play();
    }



    void HandleHits()
    {
       // print("Brick hit");
        timesHit++;
        Maxhits = hitSprites.Length + 1;
        if (timesHit >= Maxhits)
        {
            breakableCount--;
            levelmanager.BricksDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
        /*
         * If the ball goes through the brick
         * instead of bouncing off
         * use OnCollisionExit()
         */
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        
    }

    

    // Update is called once per frame
    void Update ()
    {
		
	}
}
