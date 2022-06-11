using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{

    [SerializeField]
    private float globalSpeed = 1.0f;
    [SerializeField]
    private Material rua;
    [SerializeField]
    private float RealObjectsSpeedMultiplier=10.0f;

    public static float GlobalSpeed;

    void Awake(){

    }
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
            rua.SetFloat("_Speed", globalSpeed);
            GlobalSpeed = globalSpeed * RealObjectsSpeedMultiplier;
        
    }
}
