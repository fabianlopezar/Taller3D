using UnityEngine;
using TMPro;
public class PickUp : MonoBehaviour
{
    public int perroCount=0;
    public TMP_Text _perroTMP;
    public int gatoCount = 0;
    public TMP_Text _gatoTMP;
    public int gallinaCount = 0;
    public TMP_Text _gallinaTMP;
    public int caballoCount = 0;
    public TMP_Text _caballoTMP;    
    
    // [Segundo Nivel]
    public int coin = 0;
    public TMP_Text _coinTMP;

    private void OnTriggerEnter(Collider other)
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
