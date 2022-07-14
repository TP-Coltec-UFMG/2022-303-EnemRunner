using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoDasColunas : MonoBehaviour
{
    public float colunaUmX;
    public float colunaDoisX;
    public float colunaTresX;

    void Awake()
    {

        colunaUmX = Screen.width * 16 / 100;
        colunaDoisX = Screen.width * 1 / 2;
        colunaTresX = Screen.width * 83 / 100;


    }
    void Start()
    {
        

    }


    void Update()
    {

    }
}
