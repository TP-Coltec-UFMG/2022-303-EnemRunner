using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDeSons : MonoBehaviour
{
    public static ManagerDeSons Instance;

 
    [SerializeField]
    private AudioSource somImpacto;

    [SerializeField] private AudioSource musicaBackground;

    public void TocaSomImpacto()
    {
        somImpacto.Play();
    }
    public void ParaMusicaBackground()
    {
        musicaBackground.Stop();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
