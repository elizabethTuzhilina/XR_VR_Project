using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Transform[] spawnPoints;

    public int numberOfEnemies;

    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnEnemy", 2.0f,1);
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];
        GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        NavMeshAgent navMeshAgent = enemy.GetComponent<NavMeshAgent>();
        
        navMeshAgent.Warp(spawnPoint.position);
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}