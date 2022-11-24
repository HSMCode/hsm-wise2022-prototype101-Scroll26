using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoys : MonoBehaviour
{

    public GameObject Decoy;
    public GameObject[] Decoys;
    public int spawnAmount = 10;
    public float spawnPositionX = 10f;
    public float spawnPositionZ = 10f;
    public float startDelay = 3f;
    public float spawnInterval = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawningDecoyParam(spawnAmount);  

        //InvokeRepeating("SpawningDecoy", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            //SpawningDecoyParam(spawnAmount);
            SpawningDecoyParam(spawnAmount);
        }
    }

    /* void SpawningDecoy()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            int decoysIndex = Random.Range(0,Decoys.Length);

            //generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));
            
            //Instatiate Decoy
            Instantiate(Decoys[decoysIndex], spawnPosition, Decoys[decoysIndex].transform.rotation);

        }
    } */

    void SpawningDecoyParam(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int decoysIndex = Random.Range(0,Decoys.Length);

            //generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3(Mathf.Floor(Random.Range(-spawnPositionX,spawnPositionX)),0.5f,Mathf.Floor(Random.Range(-spawnPositionZ,spawnPositionZ)));
            
            //Instatiate Decoy
            Instantiate(Decoys[decoysIndex], spawnPosition, Decoys[decoysIndex].transform.rotation);

        }
    }
}
