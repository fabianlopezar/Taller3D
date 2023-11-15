/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicolás donneys Alvarado 2211348
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportBack : MonoBehaviour
{
    private System.Random generadorRandom;

    public bool carrito1=false;
    /* <summary>
     Descripcion del atributo: Un atributo booleano público que representa el estado de un objeto o condición denominada "carrito1",
    inicializado en falso.
     </summary>*/
    public bool carrito2=false;
    /* <summary>
     Descripcion del atributo: Un atributo booleano similar para un segundo objeto o condición "carrito2", también inicializado en falso.
     </summary>*/
    public bool carrito3=false;
    /* <summary>
     Descripcion del atributo: Otro atributo booleano para un tercer objeto o condición "carrito3", inicializado en falso.
     </summary>*/
    public Transform destination;
    /* <summary>
     Descripcion del atributo: Una referencia pública a un componente Transform que probablemente se use para almacenar una ubicación de destino en una escena de Unity.
     </summary>*/
    public Transform[] spawns;
    /* <summary>
     Descripcion del atributo: Un arreglo público de componentes Transform que se podría utilizar para almacenar múltiples ubicaciones de aparición o "spawn points".
     </summary>*/
    public GameObject carPreFab;
    /* <summary>
     Descripcion del atributo:Una referencia pública a un GameObject prefabricado de Unity que podría representar un "carrito" o vehículo en el juego.
     </summary>*/

    public string sceneName;
    /* <summary>
     Descripcion del atributo: Un atributo público que contiene el nombre de una escena de Unity, posiblemente utilizado para cargar o identificar una escena específica en el juego.
     </summary>*/

    public void Start()
    /* <summary>
 Descripcion del metodo: Este es un método especial en Unity que se llama automáticamente cuando el script se inicia por primera vez.
    Se utiliza comúnmente para inicializar variables o configurar el estado inicial del objeto. 
 </summary>*/

    {
        SpawnCarritos();
    }
    private void OnTriggerEnter(Collider other)
    /* <summary>
 Descripcion del metodo:Es un método de Unity que se llama automáticamente cuando otro objeto con un componente Collider
    entra en el trigger (un tipo especial de Collider configurado para detectar entradas sin generar una respuesta física de colisión)
    asociado a este script. Se utiliza comúnmente para ejecutar una lógica cuando sucede esta interacción, 
    como detectar la entrada de un jugador a una zona específica.
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
Descripcion del metodo:Un método definido por el usuario que se utiliza para mover instantáneamente
    un objeto de juego "character" a una nueva ubicación. 
</summary>*/
    {
        if (destination != null)
        {
            character.transform.position = destination.position;            
        }
        else
        {
            Debug.LogError("El destino no está configurado. Asegúrate de asignar un objeto de destino en el Inspector.");
        }
    }

    void SpawnCarritos()
    /* <summary>
Descripcion del metodo:Un método que se encarga de instanciar o activar "carritos" en la escena.
</summary>*/
    {

        generadorRandom = new System.Random();
        int numeroAleatorio = generadorRandom.Next(0, 3);

        GameObject elem = Instantiate(carPreFab, spawns[numeroAleatorio].position, spawns[numeroAleatorio].rotation);
    }
    public void CambioEscena()
    /* <summary>
Descripcion del metodo:Un método público que sugiere su uso para cambiar entre escenas en Unity.
    Puede involucrar la carga de una nueva escena basándose en el valor de alguna variable como sceneName,
    utilizando la funcionalidad de cambio de escenas de Unity.
</summary>*/
    {
        SceneManager.LoadScene(sceneName);
    }
}
