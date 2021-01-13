using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    private float startDelay = 1;
    private float repeatDelay = 1;
    private Vector3 spawnPos = new Vector3(108, 54, 50);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
}
