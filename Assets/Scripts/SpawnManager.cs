using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Transform spawnPosition;
    [SerializeField] int enemyType = 0;
    private float inicio = 2f;
    private float intervaloSpawn = 10f;
    void Start()
    {
        InvokeRepeating ("SpawnEnemigos", inicio, intervaloSpawn);
    }

    void SpawnEnemigos()
    {
        /*int enemigos = Random.Range(0, enemigosPrefabs.Length);
        Vector3 spawn = new Vector3(Random.Range(-60f,60f), 0, 60);
        Instantiate(enemigosPrefabs[enemigos], spawn, enemigosPrefabs[enemigos].transform.rotation);*/
         GameObject enemy = PoolManager.Instance.GetPooledObjects(enemyType, spawnPosition.position, spawnPosition.rotation);
            if(enemy != null)
            {
                enemy.SetActive(true);
            }else
            {
                Debug.LogError("Pool demasiado pequeno");
            }
    }
}
