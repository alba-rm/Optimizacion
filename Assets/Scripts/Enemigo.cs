using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] float enemySpeed = 15;
    void Update()
    {
       transform.position += transform.forward * enemySpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision) 
    {
        gameObject.SetActive(false);
    }
}
