using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoVertical : MonoBehaviour
{
    private Rigidbody2D rb;
    
    
   
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        rb.velocity = new Vector2(0, SpeedManager.GlobalSpeed*-1);
    }
}
