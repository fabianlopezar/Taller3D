
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination; // El objeto al que quieres teletransportar.
    /* <summary>
Descripcion del atributo:Este atributo público es una referencia a un objeto Transform que determina la ubicación de destino a la que el objeto de juego se teletransportará.
    Debe ser asignado en el Inspector de Unity.
</summary>*/

    private void OnTriggerEnter(Collider other)
    /* <summary>
Descripcion del metodo:Es un controlador de evento que Unity llama automáticamente cuando un objeto entra en el 
    trigger Collider de este objeto de juego. Si el objeto entrante tiene una etiqueta "Player",
    se llama al método TeleportCharacter con ese objeto como argumento.
</summary>*/
    {
        //    Debug.Log("Deberia funcionar");
        if (other.gameObject.CompareTag("Player")) // Asegúrate de que el personaje tenga una etiqueta "Player".
        {
    
            TeleportCharacter(other.gameObject);
        }       
    }
    
    private void TeleportCharacter(GameObject character)
    /* <summary>
Descripcion del metodo:Este método toma un GameObject como parámetro y, si el destino está definido (no es nulo), 
    establece la posición del objeto de juego al punto de destino especificado.
    Si destination es nulo, se registra un error para indicar que no se ha establecido un destino.
</summary>*/
    {
        if (destination != null)
        {
            character.transform.position = destination.position;
            // Puedes agregar más lógica aquí si deseas realizar alguna otra acción al teletransportar.
        }
        else
        {
            Debug.LogError("El destino no está configurado. Asegúrate de asignar un objeto de destino en el Inspector.");
        }
    }
}
