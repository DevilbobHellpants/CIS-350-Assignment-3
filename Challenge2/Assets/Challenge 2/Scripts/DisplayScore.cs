﻿/*
 * (Noah Trillizio)
 * (Assignment 3)
 * (displays the current score)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    public bool gameOver = false;
    public GameObject gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        //set text component reference on start
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        // Victory Condition
        if (score >= 5)
        {
            gameOver = true;
            gameOverText.SetActive(true);
            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
