/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicol�s donneys Alvarado 2211348
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject panelTutorial;
    /* <summary>
     Descripcion del atributo: Este es un atributo p�blico que se espera que est� vinculado a un objeto de juego en Unity,
    espec�ficamente al panel que contiene la informaci�n del tutorial en la interfaz de usuario.
     </summary>*/

    public void ActivarTutorial()
    /* <summary>
 Descripcion del metodo:M�todo p�blico que activa el panel del tutorial. Cuando este m�todo es invocado,
 el panelTutorial se activar�, haci�ndolo visible en la interfaz de usuario.
 </summary>*/
    {
        panelTutorial.SetActive(true);
    }
    public void DesactivarTutorial()
    /* <summary>
 Descripcion del metodo:M�todo p�blico que desactiva el panel del tutorial. Al invocarlo, el panelTutorial se desactivar�, 
    ocult�ndolo de la interfaz de usuario.
 </summary>*/
    {
        panelTutorial.SetActive(false);
    }
    

    
    public void Salir()
    /* <summary>
 Descripcion del metodo:M�todo p�blico que cierra la aplicaci�n. Este m�todo se utiliza para cerrar el juego cuando se llama.
    Cabe destacar que Application.Quit() no tendr� efecto en el editor de Unity, solo funciona en el juego una vez est� construido y ejecut�ndose fuera del editor.
 </summary>*/
    {
        Application.Quit();
    }
}
