using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoVertical : MonoBehaviour
{
    private Rigidbody2D rigidBodyObjetoAtual;

    private void AtribuiRigidBody()
    {
        rigidBodyObjetoAtual = GetComponent<Rigidbody2D>();
    }

    private void DeslocaObjetoParaBaixo()
    {
        rigidBodyObjetoAtual.velocity = new Vector2(0, SpeedManager.GlobalSpeed*-1);
    }
    void Start()
    {
        AtribuiRigidBody();
    }
    void Update()
    {
        DeslocaObjetoParaBaixo();
    }
}
