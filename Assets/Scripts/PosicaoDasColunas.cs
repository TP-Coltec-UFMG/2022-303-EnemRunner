using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoDasColunas : MonoBehaviour
{
    public float colunaUmX = Screen.width * 16 / 100;
    public float colunaDoisX = Screen.width * 1 / 2;
    public float colunaTresX = Screen.width * 83 / 100;

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
