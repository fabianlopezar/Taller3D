/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicolás donneys Alvarado 2211348
 */
using UnityEngine;
using UnityEngine.SceneManagement;


public class Paneles : MonoBehaviour
{
    public GameObject panelControles;
    public GameObject panelSonidos;
    public GameObject panelResoluciones;

    public void ActivarPanelControles()
    {
        panelControles.SetActive(true);
        panelSonidos.SetActive(false);
        panelResoluciones.SetActive(false);
    }
    public void ActivarPanelSonidos()
    {
        panelControles.SetActive(false);
        panelSonidos.SetActive(true);
        panelResoluciones.SetActive(false);
    }
    public void ActivarPanelResoluciones()
    {
        panelControles.SetActive(false);
        panelSonidos.SetActive(false);
        panelResoluciones.SetActive(true);
    }
    public void OcultarPaneles()
    {
        panelControles.SetActive(false);
        panelSonidos.SetActive(false);
        panelResoluciones.SetActive(false);
    }
    public void Nivel1()
    {        
            SceneManager.LoadScene("1");
    }

}
