using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Wave CurrentWave;
    public Transform[] SpawnPoints;

    private int enemySpawned = 0;
    private float nextSpawnedTime = 0;
    void Update()
    {
        var t = Time.time;
        if (t > nextSpawnedTime && enemySpawned < CurrentWave.EnemyCount)
        {
            Spawn();
            enemySpawned++;
            nextSpawnedTime = Time.time + CurrentWave.SpawnInterval;
        }
    }
    public void  ChangeWave(Wave wave)
    {
        CurrentWave = wave;

        enemySpawned = 0;
        nextSpawnedTime = Time.time; 
    }

    public bool IsComplete()
    {
        return enemySpawned >= CurrentWave.EnemyCount;
    }

    void Spawn()
    {
        /*animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new(
            Random.Range(-spawnRangeX, spawnRangeX),
            transform.position.y,
            transform.position.z
        );
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation
        );*/

        int enemyIndex = Random.Range(0, CurrentWave.EnemyPrefabs.Length);
        int spawnPointIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(CurrentWave.EnemyPrefabs[enemyIndex], SpawnPoints[spawnPointIndex].position, CurrentWave.EnemyPrefabs[enemyIndex].transform.rotation);
    }
}
