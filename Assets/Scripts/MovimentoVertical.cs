using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoVertical : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [SerializeField]
   
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.position += new Vector2(0, SpeedManager.GlobalSpeed *Time.fixedDeltaTime *-1);
    }
}