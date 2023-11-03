using UnityEngine;

public class TeleportBack : MonoBehaviour
{
    public bool carrito1=false;
    public bool carrito2=false;
    public bool carrito3=false;
    public Transform destination; 
    public Transform[] spawns;
    public GameObject carPreFab;

    public int carPos1;
    /*public int CarPos2;
    public int CarPos3;*/


    public void Start()
    {
        SpawnCarritos();
    }
    private void OnTriggerEnter(Collider other)
    {
        //    Debug.Log("Deberia funcionar");
        if (other.gameObject.CompareTag("back") && carrito1 && carrito2 && carrito3) // Asegúrate de que el personaje tenga una etiqueta "Player".
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
            // Puedes agregar más lógica aquí si deseas realizar alguna otra acción al teletransportar.
        }
        else
        {
            Debug.LogError("El destino no está configurado. Asegúrate de asignar un objeto de destino en el Inspector.");
        }
    }

    void SpawnCarritos()
    {
        carPos1 = Random.Range(0, 8);
        /*  CarPos2 = Random.Range(0, 8);
          CarPos3 = Random.Range(0, 8);*/

        GameObject elem = Instantiate(carPreFab, spawns[carPos1].position, spawns[carPos1].rotation);
    }
}
