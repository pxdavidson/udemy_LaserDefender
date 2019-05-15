using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Declare variables
    [SerializeField] List<WaveScriptableObject> waveConfig;
    [SerializeField] bool looping = true;
    int startingWave = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnAllWaves());
        }
        while (looping);        
    }

    // Spawn all waves
    private IEnumerator SpawnAllWaves()
    {
        for (int waveIndex = startingWave; waveIndex < waveConfig.Count; waveIndex++)
        {
            var currentWave = waveConfig[waveIndex];
            yield return StartCoroutine(SpawnEnemiesInWave(currentWave));
        }
    }

    // Spawn the enemies in the associated wave config
    private IEnumerator SpawnEnemiesInWave(WaveScriptableObject waveConfig)
    {
        for (int enemyCount = 0; enemyCount < waveConfig.GetNumberOfEnemies(); enemyCount++)
        {
            var newEnemy = Instantiate(
                waveConfig.GetEnemyPrefab(), 
                waveConfig.GetWaypoints()[0].transform.position, 
                Quaternion.identity);
            newEnemy.GetComponent<EnemyController>().SetWaveConfig(waveConfig);
            yield return new WaitForSeconds(waveConfig.GetEnemySpawnRate());
        }
    }
}
