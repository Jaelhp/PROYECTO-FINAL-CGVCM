using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SeleccionarModo()
    {
        SceneManager.LoadScene(1);
    }
    public void ModoPeaton()
    {
        SceneManager.LoadScene(2);
    }
    public void ModoConductor()
    {
        SceneManager.LoadScene(3);
    }
    public void ModoExamen()
    {
        SceneManager.LoadScene(4);
    }
    public void MenuControles()
    {
        SceneManager.LoadScene(5);
    }
    public void Atras()
    {
        SceneManager.LoadScene(0);
    }
}
