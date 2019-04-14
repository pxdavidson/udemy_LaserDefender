using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveScriptableObject : ScriptableObject
{
    // Declare variables
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject enemyPathPrefab;
    [SerializeField] float enemySpawnRate = 0.5f;
    [SerializeField] float spawnRND = 0.2f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float enemyMoveSpeed = 2;

    // Return called variable
    public GameObject   GetEnemyPrefab()      { return enemyPrefab; }
    public float        GetEnemySpawnRate()   { return enemySpawnRate; }
    public float        GetSpawnRND()         { return spawnRND; }
    public int          GetNumberOfEnemies()  { return numberOfEnemies; }
    public float        GetEnemyMoveSpeed()   { return enemyMoveSpeed; }

    // Return list of waypoints from attached prefab
    public List<Transform> GetWaypoints()
    {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in enemyPathPrefab.transform)
        {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }
}
