using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public SingleNode[] tuskenRaiders;

    public static Nodes Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
    }
}
