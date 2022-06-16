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

    private float colunaUmX;
    private float colunaDoisX;
    private float colunaTresX;



    private PosicaoDasColunas TresColunas;
    private RectTransform rt;

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

    void Start()
    {
        rt = GetComponent<RectTransform>();
        rt.transform.position = new Vector2(rt.transform.position.x, playerY);
        SalvaPosicoesDasColunas();
    }




    void MovimentoHorizontal()
    {
        if (posicaoColuna == 1)
        {
            rt.transform.position = new Vector2(colunaUmX, rt.transform.position.y);
        }
        if (posicaoColuna == 2)
        {
            rt.transform.position = new Vector2(colunaDoisX, rt.transform.position.y);
        }
        if (posicaoColuna == 3)
        {
            rt.transform.position = new Vector2(colunaTresX, rt.transform.position.y);
        }

    }
}
