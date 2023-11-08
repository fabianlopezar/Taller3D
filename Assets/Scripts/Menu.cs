using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject panelTutorial;

    public void ActivarTutorial()
    {
        panelTutorial.SetActive(true);
    }
    public void DesactivarTutorial()
    {
        panelTutorial.SetActive(false);
    }
    

    
    public void Salir()
    {
        Application.Quit();
    }
}
