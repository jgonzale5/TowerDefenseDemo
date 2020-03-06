using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public Nodes nodeScript;
    public float timeBetweenSpawns;
    //public Transform prefab;
    public EntityClass[] enemies;
    float timePassed = 0;

    private void Start()
    {
        timePassed = timeBetweenSpawns;
    }

    private void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > timeBetweenSpawns)
        {
            int r = Random.Range(0, enemies.Length);

            Transform Foo = Instantiate(enemies[r].prefab, this.transform.position, enemies[r].prefab.rotation);
            //Foo.GetComponent<CasualStroll>().nodeScript = nodeScript;
            timePassed = 0;
        }
    }
}
