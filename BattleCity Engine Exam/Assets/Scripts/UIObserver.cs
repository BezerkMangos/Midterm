using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class UIObserver : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public Player player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       text.SetText(player.getHeatlh().ToString());
    }



    
}
