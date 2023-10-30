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
        Application.Quit();
    }
    public void NivelUno()
    {
        SceneManager.LoadScene(1);
    }
    public void NivelDos()
    {
        SceneManager.LoadScene(2);
    }
    public void NivelTres()
    {
        SceneManager.LoadScene(3);
    }

    
}
