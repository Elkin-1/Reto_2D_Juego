using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{
    public void Out()
    {
        Debug.Log("he salido del jueguito ese...XD");
        SceneManager.LoadScene(0);
    }
}
