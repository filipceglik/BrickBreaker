using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null; //create an instance of a musicplayer and null it
    
    void Awake()
    {
        if (instance != null) //destroy a gameobject if it was already created
        {
            Destroy(gameObject);
            print("Duplicate music player not allowed");
        }
        else
        {
            instance = this; //if its null, 
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
	// Use this for initialization
	void Start ()
    {
                
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
