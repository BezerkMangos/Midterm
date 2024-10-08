using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{

    public BaseHealth baseHealth;
   
    void Start()
    {
        if (baseHealth == null)
        {
            gameObject.AddComponent<BaseHealth>();
        }
    }


   
    void Update()
    {
        
    }




}
