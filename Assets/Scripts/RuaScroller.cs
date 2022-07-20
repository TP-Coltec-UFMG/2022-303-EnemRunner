using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RuaScroller : MonoBehaviour
{
    [SerializeField]
    private GameObject ruaGameObject;

    [SerializeField] private GameObject ruaPrincipal;
    [FormerlySerializedAs("Pai")] [SerializeField] private Transform TransformDoPai;
    private Vector2 posicaoInicialDaCopiaDaRua;
    
    private Vector2 posicaoInicialDaRuaPrincipal;
    private GameObject instanciaDaRuaGO;

    private float meioDaTelaX;
    private float topoDaTela;
    private float fimDaTelaY;
    private Vector2 topoDaTelaCentral;
    private void SetarPosicaoInicialDasRuas()
    {
        posicaoInicialDaCopiaDaRua = topoDaTelaCentral;
        posicaoInicialDaRuaPrincipal = ruaPrincipal.transform.position;
    }

    private void GerarCopiaDaRua()
    {
        instanciaDaRuaGO = Instantiate(ruaGameObject, TransformDoPai);
        instanciaDaRuaGO.transform.position = topoDaTelaCentral;
    }

    private void InicializarVariaveisPosicaoMeioFundoETopoDaTela()
    {
        meioDaTelaX = Screen.width / 2;
        topoDaTela = Screen.height * 1.5f;
        topoDaTelaCentral = new Vector2(meioDaTelaX, topoDaTela);
        fimDaTelaY = Screen.height / 2f;
    }

    private bool SeRuaChegouAoFimDaTela()
    {
        return instanciaDaRuaGO.transform.position.y < fimDaTelaY;
    }

    private void ResetarPosicaoDasRuas()
    {
        instanciaDaRuaGO.transform.position = posicaoInicialDaCopiaDaRua;
        ruaPrincipal.transform.position = posicaoInicialDaRuaPrincipal;
    }
    
    void Start()
    {
        InicializarVariaveisPosicaoMeioFundoETopoDaTela();
        SetarPosicaoInicialDasRuas();
        GerarCopiaDaRua();
    }
    void Update()
    {
        if (SeRuaChegouAoFimDaTela()) ResetarPosicaoDasRuas();
    }
}