using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RuaScroller : MonoBehaviour
{
    [SerializeField]
    private GameObject ruaGameObject;

    [SerializeField] private GameObject ruaPrincipal;
    [SerializeField] private Transform Pai;
    private Vector2 posicaoInicialDaCopiaDaRua;
    
    private Vector2 posicaoInicialDaRuaPrincipal;
    private GameObject instanciaDaRuaGO;

    private float meioDaTelaX;
    private float topoDaTela;
    private float fimDaTelaY;
    private Vector2 topoDaTelaCentral;
    private void setaPosicaoInicialDaCopiaDaRua()
    {
        posicaoInicialDaCopiaDaRua = topoDaTelaCentral;
    }

    private void geraCopiaDaRua()
    {
        instanciaDaRuaGO = Instantiate(ruaGameObject, Pai);
        instanciaDaRuaGO.transform.position = topoDaTelaCentral;
    }

    private void inicializaVariaveisPosicaoMeioFundoETopoDaTela()
    {
        meioDaTelaX = Screen.width / 2;
        topoDaTela = Screen.height * 1.5f;
        topoDaTelaCentral = new Vector2(meioDaTelaX, topoDaTela);
        fimDaTelaY = Screen.height / 2f;
    }

    private bool testaSeRuaChegouAoFimDaTela()
    {
        return instanciaDaRuaGO.transform.position.y < fimDaTelaY;
    }

    private void resetaPosicaoDasRuas()
    {
        instanciaDaRuaGO.transform.position = posicaoInicialDaCopiaDaRua;
        ruaPrincipal.transform.position = posicaoInicialDaRuaPrincipal;
    }
    void Start()
    {
        inicializaVariaveisPosicaoMeioFundoETopoDaTela();
        setaPosicaoInicialDaCopiaDaRua();
        geraCopiaDaRua();
        posicaoInicialDaRuaPrincipal = ruaPrincipal.transform.position;
    }
    void Update()
    {
        if (testaSeRuaChegouAoFimDaTela())
        {
            resetaPosicaoDasRuas();
        }
    }
}