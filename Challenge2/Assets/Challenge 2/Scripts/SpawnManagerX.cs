/*
 * (Noah Trillizio)
 * (Assignment 3)
 * (controls the spawnig of the balls)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    public HealthSystem healthSystem;
    private DisplayScore displayScoreScript;

    // Start is called before the first frame update
    void Start()
    {
        //get a reference to the Display Score script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //get a reference to the health system script
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);

        StartCoroutine(SpawnRandomPrefabkithCoroutine());
    }

    IEnumerator SpawnRandomPrefabkithCoroutine()
    {
        //add a 3 second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver && !displayScoreScript.gameOver)
        {
            SpawnRandomBall();

            float randomDelay = Random.Range(3.0f, 5.0f);

            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        //pick a random ball index
        int prefabIndex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

}
