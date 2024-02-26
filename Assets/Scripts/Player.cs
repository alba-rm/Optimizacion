using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform gunPosition;
    [SerializeField] int bulletType = 0;
    public float speedMove = 5;
    public float hInput;
    


    

    void Update()
    {
        if(transform.position.x < -60)
        {
            transform.position = new Vector3 (-60, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 60)
        {
            transform.position = new Vector3 (60, transform.position.y, transform.position.z);
        }
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * hInput * Time.deltaTime * speedMove);
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(bulletType, gunPosition.position, gunPosition.rotation);
            if(bullet != null)
            {
                bullet.SetActive(true);
            }
            else
            {
                Debug.LogError("Pool demasiado pequeño");
            }
        }
    }
}
