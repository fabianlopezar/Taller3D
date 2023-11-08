using UnityEngine;
using TMPro;
public class PickUp : MonoBehaviour
{
    public int perroCount=0;
    /* <summary>
     Descripcion del atributo: Contador para el número de objetos "perro" recogidos.

     </summary>*/
    public TMP_Text _perroTMP;
    /* <summary>
     Descripcion del atributo:Referencia al componente TextMeshPro para mostrar el contador de "perro".

     </summary>*/
    public int gatoCount = 0;
    /* <summary>
     Descripcion del atributo: Contador para el número de objetos "gato" recogidos.

     </summary>*/
    public TMP_Text _gatoTMP;
    /* <summary>
     Descripcion del atributo: Referencia al componente TextMeshPro para mostrar el contador de "gato".

     </summary>*/
    public int gallinaCount = 0;
    /* <summary>
     Descripcion del atributo: Contador para el número de objetos "gallina" recogidos.

     </summary>*/
    public TMP_Text _gallinaTMP;
    /* <summary>
     Descripcion del atributo: Referencia al componente TextMeshPro para mostrar el contador de "gallina".
     </summary>*/
    public int caballoCount = 0;
    /* <summary>
     Descripcion del atributo: Contador para el número de objetos "caballo" recogidos.
     </summary>*/
    public TMP_Text _caballoTMP;
    /* <summary>
     Descripcion del atributo: Referencia al componente TextMeshPro para mostrar el contador de "caballo".
     </summary>*/

    // [Segundo Nivel]
    public int coin = 0;
    /* <summary>
     Descripcion del atributo: Contador para el número de monedas recogidas.

     </summary>*/
    public TMP_Text _coinTMP;
    /* <summary>
     Descripcion del atributo: Referencia al componente TextMeshPro para mostrar el contador de monedas.

     </summary>*/

    private void OnTriggerEnter(Collider other)
    /* <summary>
 Descripcion del metodo: Método que se llama automáticamente cuando otro collider entra en el trigger de este objeto de juego. 
    Comprueba la etiqueta del objeto colisionado y, dependiendo de la etiqueta, 
    destruye el objeto, incrementa el contador correspondiente y actualiza el texto en el componente TMP_Text asociado.
 </summary>*/
    {

        if (other.CompareTag("perro"))
        {
            Destroy(other.gameObject);
            perroCount++;
            _perroTMP.text =""+ perroCount;
        }
        if (other.CompareTag("gato"))
        {
            Destroy(other.gameObject);
            gatoCount++;
            _gatoTMP.text = "" + gatoCount;
        }
        if (other.CompareTag("gallina"))
        {
            Destroy(other.gameObject);
            gallinaCount++;
            _gallinaTMP.text = "" + gallinaCount;
        }
        if (other.CompareTag("caballo"))
        {
            Destroy(other.gameObject);
            caballoCount++;
            _caballoTMP.text = "" + caballoCount;
        }
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coin++;
            _coinTMP.text = "" +coin;
        }

    }
    
}
