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

    private void setaPosicaoInicialDaCopiaDaRua()
    {
        posicaoInicialDaCopiaDaRua = new Vector2(Screen.width / 2, Screen.height * 1.5f);
    }
    
    private Vector2 posicaoInicialDaRuaPrincipal;
    private GameObject instanciaDaRuaGO;

    void Start()
    {
        setaPosicaoInicialDaCopiaDaRua();
        instanciaDaRuaGO = Instantiate(ruaGameObject, Pai);
        instanciaDaRuaGO.transform.position = new Vector2(Screen.width / 2, Screen.height * 1.5f);
        posicaoInicialDaRuaPrincipal = ruaPrincipal.transform.position;
    }

    void Update()
    {
        if (instanciaDaRuaGO.transform.position.y < Screen.height / 2f)
        {
            instanciaDaRuaGO.transform.position = posicaoInicialDaCopiaDaRua;
            ruaPrincipal.transform.position = posicaoInicialDaRuaPrincipal;
        }
    }
}