using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlePlayer : MonoBehaviour
{

    private float playerY = Screen.height * 2 / 10;
    private float posicaoColuna = 2;

    [SerializeField]
    private GameObject Colunas;

    private enum colunaAtual
    {
        colunaUm,
        colunaDois,
        colunaTres

    };

    private colunaAtual playerColunaAtual;
    
    private float colunaUmX;
    private float colunaDoisX;
    private float colunaTresX;



    private PosicaoDasColunas TresColunas;
    private RectTransform rt;

    

    private void MoveEsquerda()
    {
        posicaoColuna--;
        posicaoColuna = Mathf.Max(posicaoColuna, 1);


    }
    private void MoveDireita()
    {
        posicaoColuna++;
        posicaoColuna = Mathf.Min(posicaoColuna, 3);
    }
    private void SalvaPosicoesDasColunas()
    {
        TresColunas = Colunas.GetComponent<PosicaoDasColunas>();

        colunaUmX = TresColunas.colunaUmX;
        colunaDoisX = TresColunas.colunaDoisX;
        colunaTresX = TresColunas.colunaTresX;
    }
    void MovimentoHorizontal()
    {
        if (posicaoColuna == 1)
        {
            playerColunaAtual = colunaAtual.colunaUm;
            rt.transform.position = new Vector2(colunaUmX, rt.transform.position.y);
        }
        if (posicaoColuna == 2)
        {
            playerColunaAtual = colunaAtual.colunaDois;
            rt.transform.position = new Vector2(colunaDoisX, rt.transform.position.y);
        }
        if (posicaoColuna == 3)
        {
            playerColunaAtual = colunaAtual.colunaTres;
            rt.transform.position = new Vector2(colunaTresX, rt.transform.position.y);
        }

    }

    void Start()
    {
        playerColunaAtual = colunaAtual.colunaDois;
        rt = GetComponent<RectTransform>();
        rt.transform.position = new Vector2(rt.transform.position.x, playerY);
        SalvaPosicoesDasColunas();
    }
    
    public void OnMovimento(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            float direcao;
            direcao = ctx.ReadValue<float>();
            if (direcao < 0)
            {
                MoveEsquerda();
            }
            if (direcao > 0)
            {
                MoveDireita();
            }
            MovimentoHorizontal();


        }

    }
}
