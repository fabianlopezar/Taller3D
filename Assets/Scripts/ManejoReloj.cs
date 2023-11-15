/*Fabian Esteban Lopez Arias 2216110
 * johann alberto Bocanegra 2200850
 * Nicolás donneys Alvarado 2211348
 */
using UnityEngine;
using TMPro;
using System;

public class ManejoReloj : MonoBehaviour
{
   
    public TMP_Text textMin;
    /* <summary>
    escripcion del atributo: Referencia a un objeto de texto TextMeshPro utilizado para mostrar minutos en una interfaz de usuario.
     </summary>*/
    public TMP_Text textSeg;
    /* <summary>
    escripcion del atributo: Referencia a un objeto de texto TextMeshPro utilizado para mostrar segundos en una interfaz de usuario.
     </summary>*/

    public TMP_Text textMilS;
    /* <summary>
     escripcion del atributo: Referencia a un objeto de texto TextMeshPro utilizado para mostrar milisegundos en una interfaz de usuario.
     </summary>*/
    private float startTime;
    /* <summary>
     escripcion del atributo: Almacena el punto de tiempo (en segundos) cuando se inicia un temporizador.
     </summary>*/
    private float stopTime;
    /* <summary>
    escripcion del atributo: Guarda el punto de tiempo (en segundos) cuando se detiene un temporizador.
     </summary>*/
    private float timerTime;
    /* <summary>
     escripcion del atributo: Acumula la cantidad total de tiempo (en segundos) que ha estado activo un temporizador.
     </summary>*/
    private bool isRunning = false;
    /* <summary>
     Descripcion del atributo: Indica si el temporizador está activo (true) o no (false), inicializado en falso.
     </summary>*/

    public float StartTime { get => startTime; set => startTime = value; }
    public float StopTime { get => stopTime; set => stopTime = value; }
    public float TimerTime { get => timerTime; set => timerTime = value; }
    public bool IsRunning { get => isRunning; set => isRunning = value; }

    // Start is called before the first frame update
    void Start()
    {
        //TimerReset();  
        TimerStart();
    }

    public void TimerReset()
    /* <summary>
     Descripcion del metodo: Este método se usa para reiniciar el temporizador a su estado inicial.
    Probablemente establezca el tiempo acumulado y cualquier otra variable relevante a sus valores predeterminados.
     </summary>*/


    {
        //print("RESET");
        stopTime = 0;
        isRunning = false;
        textMin.text = textSeg.text = textMilS.text = "00";
    }

    public void TimerStart()
    /* <summary>
 Descripcion del metodo: Este método se encarga de iniciar o reanudar el temporizador.
    Puede establecer un valor de inicio y cambiar un indicador para que el temporizador comience a contar el tiempo.
 </summary>*/
    {
        if (!isRunning)
        {
          //  print("START");
            isRunning = true;
            startTime = Time.time;
        }
    }

    public void TimerStop()
    /* <summary>
 Descripcion del metodo: Este método se utiliza para detener el temporizador. Podría guardar un tiempo de parada, 
    detener la actualización del tiempo acumulado y cambiar un indicador para reflejar que el temporizador no está activo.
 </summary>*/
    {
        if (isRunning)
        {
            //print("STOP");
            isRunning = false;
            stopTime = timerTime;
            Debug.Log(stopTime.ToString());
        }
    }

        void Update()
    {
        Cronometro();
    }

    private void Cronometro()
    /* <summary>
 Descripcion del metodo: Dado que este método es privado, solo es accesible dentro de la clase en la que se declara.
    Su nombre sugiere que podría contener la lógica para actualizar el cronómetro,
    posiblemente incrementando el contador de tiempo y actualizando las variables asociadas mientras el temporizador está activo.
 </summary>*/
    {
         timerTime = stopTime + (Time.time - startTime);
        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;
        int seconds100Int = (int)(Math.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));
        if (isRunning)
        {
            textMin.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            textSeg.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            textMilS.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
    }
}
