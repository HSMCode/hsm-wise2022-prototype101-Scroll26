using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject[] Enemies;
    public int spawnAmount = 10;
    public float spawnPositionX = 10f;
    public float spawnPositionZ = 10f;
    [SerializeField] float repeatRateOnStart = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //SpawningEnemyParam(spawnAmount);
        InvokeRepeating(methodName:"SpawningEnemies", time:3f, repeatRateOnStart);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SpawningEnemyParam(spawnAmount);
        }
    }

    void SpawningEnemies()
    {
        SpawningEnemyParam(spawnAmount);
    }

    void SpawningEnemyParam(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int enemiesIndex = Random.Range(0,Enemies.Length);

            //generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(Mathf.Floor(Random.Range(-spawnPositionX,spawnPositionX)),0.5f,Mathf.Floor(Random.Range(-spawnPositionZ,spawnPositionZ)));
            
            //Instatiate Enemy
            Instantiate(Enemies[enemiesIndex], spawnPosition, Enemies[enemiesIndex].transform.rotation);

        }    
    }
}
