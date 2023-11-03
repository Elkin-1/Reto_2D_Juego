using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Debug.Log("he salido del jueguito ese...XD");
        Application.Quit();
    }

    public void Volver()
    {
        SceneManager.LoadScene(0);
    }
    
    public void SeleccioneNivel()
    {
        SceneManager.LoadScene(1);
    }
    public void NivelUno()
    {
        SceneManager.LoadScene(2);
    }
    public void NivelDos()
    {
        SceneManager.LoadScene(3);
    }
    public void NivelTres()
    {
        SceneManager.LoadScene(4);
    }

    
}
