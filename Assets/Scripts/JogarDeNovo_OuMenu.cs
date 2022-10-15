using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogarDeNovo_OuMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverGameObject;
    private ControlePlayer jogador;


    public void CarregaMenuInicial()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void CarregaTelaGameOver()
    {
        gameOverGameObject.SetActive(true);
    }
    
    void Start()
    {
        jogador = GameObject.FindObjectOfType<ControlePlayer>();
    }
    
    void Update()
    {
        
    }
}
