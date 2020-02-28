using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleNode : MonoBehaviour
{
    public SingleNode[] nextNode;

    public SingleNode GetNextNode()
    {
        if (nextNode.Length < 1)
            return null;

        return nextNode[Random.Range(0, nextNode.Length)];
    }
}
