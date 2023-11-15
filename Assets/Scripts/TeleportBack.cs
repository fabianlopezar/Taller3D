/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicol�s donneys Alvarado 2211348
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBack : MonoBehaviour
{
    private System.Random generadorRandom;

    public bool carrito1=false;
    /* <summary>
     Descripcion del atributo: Un atributo booleano p�blico que representa el estado de un objeto o condici�n denominada "carrito1",
    inicializado en falso.
     </summary>*/
    public bool carrito2=false;
    /* <summary>
     Descripcion del atributo: Un atributo booleano similar para un segundo objeto o condici�n "carrito2", tambi�n inicializado en falso.
     </summary>*/
    public bool carrito3=false;
    /* <summary>
     Descripcion del atributo: Otro atributo booleano para un tercer objeto o condici�n "carrito3", inicializado en falso.
     </summary>*/
    public Transform destination;
    /* <summary>
     Descripcion del atributo: Una referencia p�blica a un componente Transform que probablemente se use para almacenar una ubicaci�n de destino en una escena de Unity.
     </summary>*/
    public Transform[] spawns;
    /* <summary>
     Descripcion del atributo: Un arreglo p�blico de componentes Transform que se podr�a utilizar para almacenar m�ltiples ubicaciones de aparici�n o "spawn points".
     </summary>*/
    public GameObject carPreFab;
    /* <summary>
     Descripcion del atributo:Una referencia p�blica a un GameObject prefabricado de Unity que podr�a representar un "carrito" o veh�culo en el juego.
     </summary>*/

    public string sceneName;
    /* <summary>
     Descripcion del atributo: Un atributo p�blico que contiene el nombre de una escena de Unity, posiblemente utilizado para cargar o identificar una escena espec�fica en el juego.
     </summary>*/

    public void Start()
    /* <summary>
 Descripcion del metodo: Este es un m�todo especial en Unity que se llama autom�ticamente cuando el script se inicia por primera vez.
    Se utiliza com�nmente para inicializar variables o configurar el estado inicial del objeto. 
 </summary>*/

    {
        SpawnCarritos();
    }
    private void OnTriggerEnter(Collider other)
    /* <summary>
 Descripcion del metodo:Es un m�todo de Unity que se llama autom�ticamente cuando otro objeto con un componente Collider
    entra en el trigger (un tipo especial de Collider configurado para detectar entradas sin generar una respuesta f�sica de colisi�n)
    asociado a este script. Se utiliza com�nmente para ejecutar una l�gica cuando sucede esta interacci�n, 
    como detectar la entrada de un jugador a una zona espec�fica.
 </summary>*/
    {

        if (other.gameObject.CompareTag("back")  ) 
        {

            TeleportCharacter(this.gameObject);
        }
        if (other.gameObject.CompareTag("carrito1"))
        {
            carrito1 = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("carrito2"))
        {
            carrito2 = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("carrito3"))
        {
            carrito3 = true;
            Destroy(other.gameObject);
        }
        if (carrito1 && carrito2 && carrito3)
        {

            CambioEscena();
        }
    }
    private void TeleportCharacter(GameObject character)
    /* <summary>
Descripcion del metodo:Un m�todo definido por el usuario que se utiliza para mover instant�neamente
    un objeto de juego "character" a una nueva ubicaci�n. 
</summary>*/
    {
        if (destination != null)
        {
            character.transform.position = destination.position;            
        }
        else
        {
            Debug.LogError("El destino no est� configurado. Aseg�rate de asignar un objeto de destino en el Inspector.");
        }
    }

    void SpawnCarritos()
    /* <summary>
Descripcion del metodo:Un m�todo que se encarga de instanciar o activar "carritos" en la escena.
</summary>*/
    {

        generadorRandom = new System.Random();
        int numeroAleatorio = generadorRandom.Next(0, 3);

        GameObject elem = Instantiate(carPreFab, spawns[numeroAleatorio].position, spawns[numeroAleatorio].rotation);
    }
    public void CambioEscena()
    /* <summary>
Descripcion del metodo:Un m�todo p�blico que sugiere su uso para cambiar entre escenas en Unity.
    Puede involucrar la carga de una nueva escena bas�ndose en el valor de alguna variable como sceneName,
    utilizando la funcionalidad de cambio de escenas de Unity.
</summary>*/
    {
        SceneManager.LoadScene(sceneName);
    }
}
