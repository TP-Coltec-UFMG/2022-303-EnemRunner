using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ControlePlayer : MonoBehaviour
{
    #region Variáveis
    public enum ColunaAtual
    {
        Um = 1,
        Dois = 2,
        Tres = 3
    };
    
    private float colunaUmX;
    private float colunaDoisX;
    private float colunaTresX;
    
    private float playerY = Screen.height * 2 / 10;
    private float posicaoColuna = 2;

    private JogarDeNovo_OuMenu JogarDeNovoMenu;

    private PosicaoDasColunas Colunas;
    
    private ColunaAtual playerColunaAtual;
    
    private PosicaoDasColunas TresColunas;
    private RectTransform rt;
    
    private Transform _transform;

    private ManagerDeSons soundManager;
    
    #endregion
    
    #region Métodos Públicos
    public ColunaAtual RetornaColunaAtualPlayer()
    {
        return playerColunaAtual;
    }
    public void OnMovimento(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            float direcao = ctx.ReadValue<float>();
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
    #endregion
    
    void Start()
    {
        ObtemReferenciasDosObjetos();
        DesativaMenuDerrota();
        DefineColunaInicial();
        SalvaPosicoesDasColunas();
    }

    #region Métodos Privados

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

    private void MovimentoHorizontal()
    {
        if (posicaoColuna == 1)
        {
            playerColunaAtual = ColunaAtual.Um;
            _transform.position = new Vector2(colunaUmX, _transform.position.y);
        }

        if (posicaoColuna == 2)
        {
            playerColunaAtual = ColunaAtual.Dois;
            _transform.position = new Vector2(colunaDoisX, _transform.position.y);
        }

        if (posicaoColuna == 3)
        {
            playerColunaAtual = ColunaAtual.Tres;
            _transform.position = new Vector2(colunaTresX, _transform.position.y);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D obstaculoColidido)
    {
        Time.timeScale = 0;
        soundManager.TocaSomImpacto();
        soundManager.ParaMusicaBackground();
        JogarDeNovoMenu.gameObject.SetActive(true);
        JogarDeNovoMenu.CarregaTelaGameOver();
    }

    private void DesativaMenuDerrota()
    {
        JogarDeNovoMenu.gameObject.SetActive(false);
    }

    private void ObtemReferenciasDosObjetos()
    {
        JogarDeNovoMenu = FindObjectOfType<JogarDeNovo_OuMenu>();
        Colunas = FindObjectOfType<PosicaoDasColunas>();
        soundManager = FindObjectOfType<ManagerDeSons>();
        _transform = GetComponent<Transform>();
    }

    private void DefineColunaInicial()
    {
        playerColunaAtual = ColunaAtual.Dois;
        _transform.position = new Vector2(_transform.position.x, playerY);
    }
    #endregion
}