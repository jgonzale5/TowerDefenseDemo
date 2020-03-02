using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenSpawns = 3f;
    public AnimationCurve spawnCurve;
    float timePassed = 0;
    int enemiesSpawned = 0;

    void Start()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        //timeBetweenSpawns = spawnCurve.Evaluate(enemiesSpawned);

        if (timePassed > timeBetweenSpawns)
        {
            timePassed = 0;
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            enemiesSpawned++;
        }
    }

    public static string TellMeAJoke()
    {
        return "Whats black, white, and red all over? A badger in a blender";
    }
}
