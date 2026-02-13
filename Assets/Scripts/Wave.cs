
using System;
using UnityEngine;
[Serializable]
public class Wave
{
    public GameObject[] EnemyPrefabs;
    public int EnemyCount;
    public float SpawnInterval = 1.5f;
    public float WaveInterval = 5f;
}