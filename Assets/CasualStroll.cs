using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualStroll : MonoBehaviour
{
    public Nodes nodeScript;
    public float speed = 1f;
    float currentProgress = 0;
    int currentTarget = 0;
    SingleNode currentNode;
    SingleNode nextNode;

    private void Start()
    {
        //nodeScript = GameObject.FindObjectOfType<Nodes>();
        nodeScript = Nodes.Instance;
        currentNode = nodeScript.tuskenRaiders[0];
        nextNode = currentNode.GetNextNode();
    }

    // Update is called once per frame
    void Update()
    {
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

                currentNode.transform.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        //Moving through targets in order
        //if (currentTarget < nodeScript.tuskenRaiders.Length - 1)
        //{
        //    int nextTarget = (currentTarget + 1) % nodeScript.tuskenRaiders.Length;
        //    Vector3 A, B;
        //    A = nodeScript.tuskenRaiders[currentTarget].transform.position;
        //    B = nodeScript.tuskenRaiders[nextTarget].transform.position;

        //    currentProgress = (currentProgress + speed * Time.deltaTime);

        //    this.transform.position = Vector3.Lerp(A, B, currentProgress);

        //    if (currentProgress >= 1)
        //    {
        //        currentTarget = (currentTarget + 1) % nodeScript.tuskenRaiders.Length;
        //        currentProgress = 0;
        //    }
        //}
    }
}
