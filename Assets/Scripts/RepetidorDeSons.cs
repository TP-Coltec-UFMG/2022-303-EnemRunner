using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetidorDeSons : MonoBehaviour
{

    private AudioSource somFolhas;
    public void ParaSomFolhas(){
        somFolhas.Stop();
    }
    private void Start()
    {
        somFolhas = FindObjectOfType<AudioSource>();
        somFolhas.Play();
    }

    void Update()
    {
        if (Time.timeScale == 0){
            ParaSomFolhas();
        }
    }
}
