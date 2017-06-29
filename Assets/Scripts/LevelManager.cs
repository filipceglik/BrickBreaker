using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
        SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void BricksDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }

    internal void LoadNextLevel()
    {
        //SceneManager.GetActiveScene().buildIndex is an equivalent of Application.loadedlevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
