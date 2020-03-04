using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyClassScriptable[] enemyTypes;
    public Transform spawnPoint;
    public float timeBetweenSpawns = 3f;
    public AnimationCurve spawnCurve;
    float timePassed = 0;
    int enemiesSpawned = 0;

    void Start()
    {
        int number = Random.Range(0, enemyTypes.Length);
        Instantiate(enemyTypes[number].prefab, spawnPoint.position, Quaternion.identity);
        timeBetweenSpawns = enemyTypes[number].cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        //timeBetweenSpawns = spawnCurve.Evaluate(enemiesSpawned);

        if (timePassed > timeBetweenSpawns)
        {
            timePassed = 0;
            int number = Random.Range(0, enemyTypes.Length);
            Instantiate(enemyTypes[number].prefab, spawnPoint.position, Quaternion.identity);
            timeBetweenSpawns = enemyTypes[number].cooldown;
            enemiesSpawned++;
        }
    }

    public static string TellMeAJoke()
    {
        return "Whats black, white, and red all over? A badger in a blender";
    }
}
