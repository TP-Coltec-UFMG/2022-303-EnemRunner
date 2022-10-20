using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MetrosCorridos : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private float timer;

    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();
    }

    void Update()
    {
        if(Time.timeScale != 0){
            timer += Time.deltaTime;
            timer = timer += SpeedManager.GlobalSpeed/100000 ;
        }
        Text.text = "Distância Percorrida: " + timer.ToString("f2") + " metros";
    }

    
}
