using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject firePos;
    public GameObject lookToPos;
    public GameObject Bullet;

    [SerializeField]
    int Health = 20;


    void Start()
    {
        
    }

  
    void Update()
    {
        Move();
        Rotate();
        Shoot();
    }

    //Move
    void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left);          
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right);  
        }     
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward);      
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back);  
        }
    }


    // Press Q rotate left, PRess E rotate Right
    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.up,90f);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -90f);
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, firePos.transform.position,Quaternion.identity);
        }
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Health = Health - 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Health = Health - 1;
        }
    }




    public int getHeatlh()
    {
        return Health;
    }
}



