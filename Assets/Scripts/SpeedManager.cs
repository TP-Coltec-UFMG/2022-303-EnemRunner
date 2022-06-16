using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{

    [SerializeField]
    private float globalSpeed = 0.6f;

    [SerializeField]
    public static float GlobalSpeed;
    [SerializeField]
    private Material rua;
   
    


    void Update()
    {


        GlobalSpeed = globalSpeed * Screen.height;
        rua.SetFloat("_Speed", globalSpeed);

        
        
    }
}
