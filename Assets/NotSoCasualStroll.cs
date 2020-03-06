using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotSoCasualStroll : CasualStroll
{

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("A");

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

                currentNode.Kill();
            }
        }
    }
}
