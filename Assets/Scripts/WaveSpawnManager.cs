using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{
    public Wave[] WaveConfigs;
    public WaveController WaveController;

    private int currentWaveIndex = 0;
    private float waveEndTime = 0;

    void Start()
    {
        WaveController.ChangeWave(WaveConfigs[0]);
    }

    void Update()
    {
        if (WaveController.IsComplete())
        {
            currentWaveIndex++;
            if (currentWaveIndex < WaveConfigs.Length)
            {
                WaveController.ChangeWave(WaveConfigs[currentWaveIndex]);
            }
            else
            {
                Debug.Log("All Done");
            }
        }
    }
}