using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_menu : MonoBehaviour
{

    public void MoveScene(int Scene){

        SceneManager.LoadScene(Scene);

    }

    public void Quit(){

        Application.Quit();
    }
    



}
