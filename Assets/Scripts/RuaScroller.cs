using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuaScroller : MonoBehaviour
{
    [SerializeField]
   private GameObject ruaGO;
    [SerializeField]
   private GameObject ruaPrincipal;
   [SerializeField]
   private Transform Pai;

   private RectTransform rt;
   private Vector2 posicaoInicial = new Vector2(Screen.width/2, Screen.height*1.5f );
   private Vector2 posicaoInicialDaRuaPrincipal;
   private GameObject instanciaDaRuaGO;
    void Start()
    {
        rt = GetComponent<RectTransform>();
        instanciaDaRuaGO = Instantiate(ruaGO,Pai);
        instanciaDaRuaGO.transform.position =new Vector2(Screen.width/2, Screen.height*1.5f ); 
        posicaoInicialDaRuaPrincipal = ruaPrincipal.transform.position;

    }
    void Update()
    {
        if(instanciaDaRuaGO.transform.position.y<Screen.height/2f){
            instanciaDaRuaGO.transform.position = posicaoInicial;
            ruaPrincipal.transform.position = posicaoInicialDaRuaPrincipal;
        }
    
    }
}
