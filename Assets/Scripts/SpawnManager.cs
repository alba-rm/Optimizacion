using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemigosPrefabs;
    private float inicio = 2.0f;
    private float intervaloSpawn = 1.5f;
    void Start()
    {
        InvokeRepeating ("SpawnManager", inicio, intervaloSpawn);
    }

    // Update is called once per frame
    void SpawnEnemigos()
    {
        int enemigos = Random.Range(0, enemigosPrefabs.Length);
        Vector3 spawn = new Vector3(Random.Range(-60f,60f), 0, 60);
        Instantiate(enemigosPrefabs[enemigos], spawn, enemigosPrefabs[enemigos].transform.rotation);
    }
}
