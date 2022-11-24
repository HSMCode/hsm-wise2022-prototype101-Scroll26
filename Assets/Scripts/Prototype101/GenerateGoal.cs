using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGoal : MonoBehaviour
{
    public GameObject Goal;

    public float minSpawnPositionX = 5f;
    public float minSpawnPositionZ = 5f;
    public float maxSpawnPositionX = 10f;
    public float maxSpawnPositionZ = 10f;

    // Start is called before the first frame update
    void Start()
    {
        SpawningGoal();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawningGoal()
    {
        Vector3 spawnPosition = new Vector3(((Random.Range(0,2)* 2) - 1) * Mathf.Floor(Random.Range(minSpawnPositionX,maxSpawnPositionX)),0.5f,((Random.Range(0,2)* 2) - 1) * Mathf.Floor(Random.Range(minSpawnPositionZ,maxSpawnPositionZ)));

        Instantiate(Goal, spawnPosition, Goal.transform.rotation);
    }
}
