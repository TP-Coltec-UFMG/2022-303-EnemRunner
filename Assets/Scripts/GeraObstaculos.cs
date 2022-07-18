using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GeraObstaculos : MonoBehaviour
{
    #region Variáveis
    
    private float timer = 0;
    [SerializeField]
    private float cooldown = 3f;

    [SerializeField]
    private GameObject ObjetoAlvo;
    [FormerlySerializedAs("Pai")] [SerializeField]
    private Transform TransformDoPai;
    
    private PosicaoDasColunas Colunas;
    
    public float colunaUmX;
    public float colunaDoisX;
    public float colunaTresX;

    private PosicaoDasColunas TresColunas;

    private float colunaRandom;
    
    #endregion

    #region Métodos

    private void SalvaPosicoesDasColunas()
    {
        colunaUmX = TresColunas.colunaUmX;
        colunaDoisX = TresColunas.colunaDoisX;
        colunaTresX = TresColunas.colunaTresX;
    }

    private void ObtemReferenciaDosObjetos()
    {
        Colunas = FindObjectOfType<PosicaoDasColunas>();
        TresColunas = Colunas.GetComponent<PosicaoDasColunas>();
    }

    private void SelecionaColunaAleatoria()
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
    }

    private void ResetaTemporizador()
    {
        timer = 0;
    }

    private void Temporizador()
    {
        timer += Time.fixedDeltaTime;
    }
    private void GeraObjetoAtual()
    {
        GameObject instanciaDoObjetoAtual = Instantiate(ObjetoAlvo, new Vector3(colunaRandom, Screen.height + 200, 0), Quaternion.identity, TransformDoPai);
        Destroy(instanciaDoObjetoAtual, 2f);
    }

    private bool CooldownAcabou()
    {
        return timer > cooldown;
    }

    #endregion
    
    
    void Start()
    {
        ObtemReferenciaDosObjetos();
        SalvaPosicoesDasColunas();
    }
    
    void FixedUpdate()
    {
        Temporizador();
        if (CooldownAcabou())
        {
            SelecionaColunaAleatoria();
            GeraObjetoAtual();
            ResetaTemporizador();
        }
    }
}
    


