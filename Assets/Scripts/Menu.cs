/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicolás donneys Alvarado 2211348
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject panelTutorial;
    /* <summary>
     Descripcion del atributo: Este es un atributo público que se espera que esté vinculado a un objeto de juego en Unity,
    específicamente al panel que contiene la información del tutorial en la interfaz de usuario.
     </summary>*/

    public void ActivarTutorial()
    /* <summary>
 Descripcion del metodo:Método público que activa el panel del tutorial. Cuando este método es invocado,
 el panelTutorial se activará, haciéndolo visible en la interfaz de usuario.
 </summary>*/
    {
        panelTutorial.SetActive(true);
    }
    public void DesactivarTutorial()
    /* <summary>
 Descripcion del metodo:Método público que desactiva el panel del tutorial. Al invocarlo, el panelTutorial se desactivará, 
    ocultándolo de la interfaz de usuario.
 </summary>*/
    {
        panelTutorial.SetActive(false);
    }
    

    
    public void Salir()
    /* <summary>
 Descripcion del metodo:Método público que cierra la aplicación. Este método se utiliza para cerrar el juego cuando se llama.
    Cabe destacar que Application.Quit() no tendrá efecto en el editor de Unity, solo funciona en el juego una vez esté construido y ejecutándose fuera del editor.
 </summary>*/
    {
        Application.Quit();
    }
}
