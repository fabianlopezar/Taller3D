
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination; // El objeto al que quieres teletransportar.
    /* <summary>
Descripcion del atributo:Este atributo p�blico es una referencia a un objeto Transform que determina la ubicaci�n de destino a la que el objeto de juego se teletransportar�.
    Debe ser asignado en el Inspector de Unity.
</summary>*/

    private void OnTriggerEnter(Collider other)
    /* <summary>
Descripcion del metodo:Es un controlador de evento que Unity llama autom�ticamente cuando un objeto entra en el 
    trigger Collider de este objeto de juego. Si el objeto entrante tiene una etiqueta "Player",
    se llama al m�todo TeleportCharacter con ese objeto como argumento.
</summary>*/
    {
        //    Debug.Log("Deberia funcionar");
        if (other.gameObject.CompareTag("Player")) // Aseg�rate de que el personaje tenga una etiqueta "Player".
        {
    
            TeleportCharacter(other.gameObject);
        }       
    }
    
    private void TeleportCharacter(GameObject character)
    /* <summary>
Descripcion del metodo:Este m�todo toma un GameObject como par�metro y, si el destino est� definido (no es nulo), 
    establece la posici�n del objeto de juego al punto de destino especificado.
    Si destination es nulo, se registra un error para indicar que no se ha establecido un destino.
</summary>*/
    {
        if (destination != null)
        {
            character.transform.position = destination.position;
            // Puedes agregar m�s l�gica aqu� si deseas realizar alguna otra acci�n al teletransportar.
        }
        else
        {
            Debug.LogError("El destino no est� configurado. Aseg�rate de asignar un objeto de destino en el Inspector.");
        }
    }
}
