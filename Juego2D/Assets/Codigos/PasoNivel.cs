using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasoNivel : MonoBehaviour
{
    public int numeroEscena;
    //trigger
    private void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Player")){
        
        if(numeroEscena==0)
        {
          SceneManager.LoadScene(0);
        }
          else
        {

          Debug.Log("Se hizo disparar!!!"+numeroEscena);
          SceneManager.LoadScene(numeroEscena+1);
        }
    }
  }
}
