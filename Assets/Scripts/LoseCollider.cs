using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private LevelManager levelmanager;

    void Start()
    {
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        levelmanager.LoadLevel("Loose Screen");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

}
