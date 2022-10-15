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
        timer += Time.deltaTime;
        Text.text = "Metros Corridos: " + timer.ToString("f2");
    }
}
