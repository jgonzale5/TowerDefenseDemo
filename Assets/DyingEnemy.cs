using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingEnemy : EnemyScript
{
    public Transform spawnParticle;

    private void Awake()
    {
        //not working because function is a private function
        //private functions/variables do not inherit
        //public and protected ones do
        //tellMeSomething();
    }
    
    //private void Start()
    //{
    //    Debug.Log("Hello");
    //}

    public override void WhenSpawns()
    {
        Instantiate(spawnParticle, this.transform.position, spawnParticle.rotation);
    }
}
