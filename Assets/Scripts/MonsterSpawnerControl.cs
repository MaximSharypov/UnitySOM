using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnerControl : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] mosquito;
    int randomSpawnPoint, randomMosquito;
    public static bool spawnAllowed;
    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating ("SpawnAMonster", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAllowed){
            randomSpawnPoint = Random.Range (1, spawnPoints.Length);
            randomMosquito = Random.Range (1, mosquito.Length);
            Instantiate (mosquito [randomMosquito], spawnPoints [randomSpawnPoint]. position, Quaternion.identity);
        }
        
    }
}
