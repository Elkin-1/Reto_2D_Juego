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
        Debug.Log("El malparido al fin se hizo disparar!!!");
        SceneManager.LoadScene(numeroEscena);
    }
  }
}
