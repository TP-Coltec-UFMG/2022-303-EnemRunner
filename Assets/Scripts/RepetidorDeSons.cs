using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetidorDeSons : MonoBehaviour
{

    [SerializeField] private AudioSource tickEcolocalizacao;
    public float cooldown = 0.01f;
    private float momentoDoUltimoTick = 0;

    void Update()

    {

        float tempoAtual = Time.time;
        if (tempoAtual > momentoDoUltimoTick + cooldown)
        {
            momentoDoUltimoTick = tempoAtual;
            tickEcolocalizacao.Play();

        }
    }
}
