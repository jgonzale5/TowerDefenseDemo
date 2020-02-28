using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public Nodes nodeScript;
    public float timeBetweenSpawns;
    public Transform prefab;
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
            Transform Foo = Instantiate(prefab, this.transform.position, prefab.rotation);
            //Foo.GetComponent<CasualStroll>().nodeScript = nodeScript;
            timePassed = 0;
        }
    }
}
