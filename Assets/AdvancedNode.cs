using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedNode : SingleNode
{
    public Transform deathExplosion;

    public override void Explosion()
    {
        Debug.Log("Explosion");
        Instantiate(deathExplosion, this.transform.position, Quaternion.identity);
    }
}
