using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copa : MonoBehaviour
{
    private float tiempo;
  //colisiones
  private void OnCollisionEnter2D(Collision2D other){
    if(other.collider.CompareTag("Player")){
        Debug.Log("El malparido al fin se hizo notar!!!");
    }
  }
  
  private void OnCollisionStay2D(Collision2D other){
    if(other.collider.CompareTag("Player")){
        tiempo += Time.deltaTime;
        Debug.Log("El malparido esta en el bloque!!!");
    }
  }
  
  private void OnCollisionExit2D(Collision2D other){
    if(other.collider.CompareTag("Player")){
        Debug.Log("El malparido salio del elemento y estuvo !!! "+tiempo);
        tiempo=0;
    }
  }
}
