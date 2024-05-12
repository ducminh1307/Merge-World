using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skin Data", menuName = "Scritpable Objects/Skin Data", order = 0)]
public class SkinDataSO : ScriptableObject
{
    [SerializeField]
    private Planet[] objectPrefabs;

    [SerializeField]
    private Planet[] spawnablePrefabs;
}
