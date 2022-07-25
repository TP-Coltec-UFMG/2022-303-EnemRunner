using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraLateral : MonoBehaviour
{
    private Slider barraLateral;
    [SerializeField]
    private float FillSpeed = 0.1f;
    private float progressoAlvo = 0;
    private void Awake() {
        barraLateral = gameObject.GetComponent<Slider>();

    }

    void Start()
    {
        IncrementProgress(1f);
    }

    
    void Update()
    {
        if (barraLateral.value < progressoAlvo)
        {
            barraLateral.value += FillSpeed * Time.deltaTime;
        }   
    }

    public void IncrementProgress(float newProgress)
    {
        progressoAlvo = barraLateral.value + newProgress;
    }

}
