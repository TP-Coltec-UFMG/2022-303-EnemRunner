using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoObstaculo : MonoBehaviour
{
    private ControlePlayer posicaoPlayer;
    private ControlePlayer.ColunaAtual colunaAtualPlayer;
    private ControlePlayer.ColunaAtual colunaAtualDoObstaculo;
    private GeraObstaculos GeradorDeObstaculos;

    
    public void DefineColunaAtualPlayer()
    {
        colunaAtualPlayer = posicaoPlayer.RetornaColunaAtualPlayer();
    }
    
    void Start()
    {
        posicaoPlayer = GameObject.FindObjectOfType<ControlePlayer>();
        GeradorDeObstaculos = GameObject.FindObjectOfType<GeraObstaculos>();


    }
    


    void Update()
    {
        DefineColunaAtualPlayer();
        
    }
}

