using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePlayer : MonoBehaviour
{

    private float playerY = Screen.height*2/10;
    private float posicaoColuna = 2;
    private bool direcao;
    [SerializeField]
    private GameObject Colunas;
    
    private float colunaUmX;
    private float colunaDoisX;
    private float colunaTresX;

   
    private PosicaoDasColunas TresColunas;
    private RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        rt.transform.position = new Vector2(rt.transform.position.x, playerY);
        SalvaPosicoesDasColunas();
    }

    private void SalvaPosicoesDasColunas()
    {
        TresColunas = Colunas.GetComponent<PosicaoDasColunas>();

        colunaUmX = TresColunas.colunaUmX;
        colunaDoisX = TresColunas.colunaDoisX;
        colunaTresX = TresColunas.colunaTresX;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow )){
            posicaoColuna--;
            posicaoColuna = Mathf.Max(posicaoColuna,1);
        }   
        else if (Input.GetKeyDown(KeyCode.RightArrow )){
            posicaoColuna++;
            posicaoColuna = Mathf.Min(posicaoColuna,3);
        }
        
        



        if(posicaoColuna == 1){
            rt.transform.position = new Vector2(colunaUmX,rt.transform.position.y);
        }
        if(posicaoColuna == 2){
            rt.transform.position = new Vector2(colunaDoisX,rt.transform.position.y);
        }
        if(posicaoColuna == 3){
            rt.transform.position = new Vector2(colunaTresX,rt.transform.position.y);
        }
        
    }
}
