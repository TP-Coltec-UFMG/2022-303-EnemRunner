using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraObstaculos : MonoBehaviour
{
    private float timer = 0;
    [SerializeField]
    private float cooldown = 3f;

    [SerializeField]
    private GameObject ObjetoAlvo;
    [SerializeField]
    private Transform Pai;

    [SerializeField]
     private GameObject Colunas;
    
    private float colunaUmX;
    private float colunaDoisX;
    private float colunaTresX;

    private PosicaoDasColunas TresColunas;

    private float colunaRandom;

    

    private void SalvaPosicoesDasColunas()
    {
        TresColunas = Colunas.GetComponent<PosicaoDasColunas>();

        colunaUmX = TresColunas.colunaUmX;
        colunaDoisX = TresColunas.colunaDoisX;
        colunaTresX = TresColunas.colunaTresX;
    }

    void Start()
    {
        SalvaPosicoesDasColunas();

    }


    void FixedUpdate()
    {

        timer += Time.fixedDeltaTime;
        if (timer > cooldown)
        {
            colunaRandom = Random.Range(0f, 1f);
            if (colunaRandom < 0.33)
            {
                colunaRandom = colunaUmX;
            }
            else if (colunaRandom < 0.66)
            {
                colunaRandom = colunaDoisX;
            }
            else
            {
                colunaRandom = colunaTresX;
            }

            GameObject instanciaDaArvore = Instantiate(ObjetoAlvo, new Vector3(colunaRandom, Screen.height, 0), Quaternion.identity, Pai);
            timer = 0;

        }
    }
}
    


