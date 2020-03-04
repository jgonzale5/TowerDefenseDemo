using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Enemy", menuName = "Enemies/Create Enemy")]
public class EnemyClassScriptable : ScriptableObject
{
    public string name;
    public Transform prefab;
    public float cooldown;
}
