
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination; // El objeto al que quieres teletransportar.

    private void OnTriggerEnter(Collider other)
    {
    //    Debug.Log("Deberia funcionar");
        if (other.gameObject.CompareTag("Player")) // Asegúrate de que el personaje tenga una etiqueta "Player".
        {
    
            TeleportCharacter(other.gameObject);
        }
    
        
    }
    
    private void TeleportCharacter(GameObject character)
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
