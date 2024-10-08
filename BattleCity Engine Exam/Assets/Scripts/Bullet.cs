using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    Rigidbody rb;


    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.fwd * Time.deltaTime * moveSpeed, ForceMode.Impulse);
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
