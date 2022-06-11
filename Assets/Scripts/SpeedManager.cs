using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{

    [SerializeField]
    private float globalSpeed = 1.0f;
    
    [SerializeField]
    public static float GlobalSpeed;
    [SerializeField]
    private Material rua;
    

    
    void Update()
    {
            rua.SetFloat("_Speed", globalSpeed);
            GlobalSpeed = globalSpeed;
            Debug.Log(Screen.height);
            
    }
}
