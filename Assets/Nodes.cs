using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public NodeScript[] nodes;

    public static Nodes Instance;
    
    void Start()
    {
        Instance = this;
    }
}
