using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : MonoBehaviour
{

    Rigidbody Rigidbody;
    GameObject TargetPos;
    public GameObject firePos;
    public GameObject Bullet;



    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        TargetPos = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SpawnBullet", 1, 5);

    }


    void Update()
    {

      

    }

    void SpawnBullet()
    {
        Instantiate(Bullet, firePos.transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

}
