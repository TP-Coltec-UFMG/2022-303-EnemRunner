using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    
    [SerializeField]
    private float globalSpeed = 0.6f;

    public static float GlobalSpeed;
    [SerializeField]
    private Material rua;
    
    [SerializeField]
    private AnimationCurve speedCurve;

    private float timer;

    private void DefineVelocidadeGeralBaseadoNoGrafico()
    {
        timer += Time.deltaTime;
        globalSpeed = speedCurve.Evaluate(timer);
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
