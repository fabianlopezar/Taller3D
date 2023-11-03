
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination; // El objeto al que quieres teletransportar.

    private void OnTriggerEnter(Collider other)
    {
    //    Debug.Log("Deberia funcionar");
        if (other.gameObject.CompareTag("Player")) // Aseg�rate de que el personaje tenga una etiqueta "Player".
        {
    
            TeleportCharacter(other.gameObject);
        }
    
        
    }
    
    private void TeleportCharacter(GameObject character)
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
