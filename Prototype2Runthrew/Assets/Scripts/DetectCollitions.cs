/*
 * (Noah Trillizio)
 * (Assignment 3)
 * (destoryes objects collide with other objects)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food projectile

public class DetectCollitions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
