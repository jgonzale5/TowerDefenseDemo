﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualStroll : MonoBehaviour
{
    public Nodes nodeScript;
    public float speed = 1f;
    protected float currentProgress = 0;
    protected int currentTarget = 0;
    protected SingleNode currentNode;
    protected SingleNode nextNode;

    protected void Start()
    {
        nodeScript = Nodes.Instance;
        currentNode = nodeScript.tuskenRaiders[0];
        nextNode = currentNode.GetNextNode();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("B");
        //Moving through nodes 
        if (nextNode != null)
        {
            Vector3 A, B;
            A = currentNode.transform.position;
            B = nextNode.transform.position;

            currentProgress = (currentProgress + speed * Time.deltaTime);

            this.transform.position = Vector3.Lerp(A, B, currentProgress);

            if (currentProgress >= 1)
            {
                currentNode = nextNode;
                nextNode = currentNode.GetNextNode();
                currentProgress = 0;

                //currentNode.transform.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
