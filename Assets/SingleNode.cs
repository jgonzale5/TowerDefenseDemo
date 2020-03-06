using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleNode : MonoBehaviour
{
    public SingleNode[] nextNode;
    protected bool Dead;

    public SingleNode GetNextNode()
    {
        if (nextNode.Length < 1)
            return null;

        return nextNode[Random.Range(0, nextNode.Length)];
    }

    public virtual void Explosion()
    {
        Debug.Log("Here then");
    }

    public virtual void Kill()
    {
        if (Dead)
            return;

        GetComponent<MeshRenderer>().enabled = false;
        Explosion();
        Dead = true;
    }
}
