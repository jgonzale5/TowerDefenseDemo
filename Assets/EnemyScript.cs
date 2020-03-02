using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Nodes nodeManager;
    public float Speed = 1f;
    //int currentIndex = 0;
    NodeScript currentNode;
    NodeScript nextNode;
    float currentPercentage = 0f;

    public static string Name = "Pedro";

    private void Start()
    {
        nodeManager = Nodes.Instance;
        int curInd = Random.Range(0, nodeManager.nodes.Length);
        currentNode = nodeManager.nodes[curInd];

        int nextNodeInd = Random.Range(0, currentNode.connections.Length);
        nextNode = currentNode.connections[nextNodeInd];
    }

    // Update is called once per frame
    void Update()
    {
        currentPercentage = currentPercentage + (Speed * Time.deltaTime);

        Vector3 A = currentNode.transform.position;
        Vector3 B = nextNode.transform.position;
               
        Vector3 newPos = Vector3.Lerp( A, B, currentPercentage);

        this.transform.position = newPos;

        if (currentPercentage >= 1)
        {
            currentPercentage = 0;
            currentNode = nextNode;
            int nextNodeInd = Random.Range(0, currentNode.connections.Length);
            nextNode = currentNode.connections[nextNodeInd];
        }
    }
}
