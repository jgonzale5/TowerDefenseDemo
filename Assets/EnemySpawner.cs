using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenSpawns = 3f;
    float timePassed = 0;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > timeBetweenSpawns)
        {
            timePassed = 0;
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        }
    }

    public static string TellMeAJoke()
    {
        return "Whats black, white, and red all over? A badger in a blender";
    }
}
