using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessStroll : NotSoCasualStroll
{
    public float minDistanceToSwitch = 0.2f;

    // Update is called once per frame
    void Update()
    {
        //Moving through nodes 
        if (nextNode != null)
        {
            Vector3 A, B;
            A = this.transform.position;
            B = nextNode.transform.position;

            Vector3 currentPos = this.transform.position;

            float distanceMovedThisFrame = speed * Time.deltaTime;

            distanceMovedThisFrame = Mathf.Clamp(distanceMovedThisFrame, 0, Vector3.Distance(A, B));

            currentPos += distanceMovedThisFrame * (B - A).normalized;

            this.transform.position = currentPos;

            if (Vector3.Distance(A, B) < minDistanceToSwitch)
            {
                currentNode = nextNode;
                nextNode = currentNode.GetNextNode();
                currentProgress = 0;

                currentNode.Kill();
            }
        }
    }
}
