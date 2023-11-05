using UnityEngine;

public class TeleportBack : MonoBehaviour
{
    private System.Random generadorRandom;

    public bool carrito1=false;
    public bool carrito2=false;
    public bool carrito3=false;
    public Transform destination; 
    public Transform[] spawns;
    public GameObject carPreFab;

    public void Start()
    {
        SpawnCarritos();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("back") && carrito1 && carrito2 && carrito3) // Aseg�rate de que el personaje tenga una etiqueta "Player".
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

    void SpawnCarritos()
    {
                
        generadorRandom = new System.Random();
        int numeroAleatorio = generadorRandom.Next(0, 8);


        GameObject elem = Instantiate(carPreFab, spawns[numeroAleatorio].position, spawns[numeroAleatorio].rotation);
    }
}
