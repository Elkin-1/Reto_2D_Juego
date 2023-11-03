using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saliendo : MonoBehaviour
{
    

    //Agregar para ver o no menu
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject boton_Salir;
    // [SerializeField] private GameObject menuPausa;
    

    // //tecla
    // private bool juegoPausado = false;


    // //t
    // public void Update(){
    //     if(Input.GetKeyDown(KeyCode.Escape)){
    //         if(juegoPausado){
    //             Reanudar();
    //         }else{
    //             Pausa();
    //         }
    //     }
    // }
    // Funcion que pausa el juego
    // public void Pausa(){
    //     juegoPausado=true;
    //     Time.timeScale = 0f;
    //     botonPausa.SetActive(false);
    //     menuPausa.SetActive(true);
    // }
    // public void Reanudar(){
    //     juegoPausado=false;
    //     Time.timeScale = 1f;
    //     botonPausa.SetActive(true);
    //     menuPausa.SetActive(false);
    // }
    // public void Reiniciar(){
    //     juegoPausado=false;
    //     Time.timeScale = 1f;
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }
    public void Cerrar(){
        Application.Quit();
        Debug.Log("Me dijeron que saliera.XD");
    }   
}
