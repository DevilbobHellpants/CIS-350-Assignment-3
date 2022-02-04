/*
 * (Noah Trillizio)
 * (Assignment 3)
 * (controls the players ability to shoot balls)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    int counter = 0;
    // Update is called once per frame
    void Update()
    {
        counter++;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (counter>=90)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                counter = 0;
            }
            //Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                //yield return new WaitForSeconds(1f);
        }
    }
}
