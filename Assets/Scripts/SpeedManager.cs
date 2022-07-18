using System;
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
    
    [SerializeField]
    private AnimationCurve speedCurve;

    private void DefineVelocidadeGeralBaseadoNoGrafico()
    {
        globalSpeed = speedCurve.Evaluate(Time.time);
    }

    private void DefineVelocidadeGeral()
    {
        GlobalSpeed = globalSpeed * Screen.height;
    }

    private void AjustaVelocidadeDoShaderRua()
    {
        rua.SetFloat("_Speed", globalSpeed);
    }

    private void Start()
    {
        
    }

    void Update()
    {
        DefineVelocidadeGeralBaseadoNoGrafico();
        DefineVelocidadeGeral();
        AjustaVelocidadeDoShaderRua();
    }
}
