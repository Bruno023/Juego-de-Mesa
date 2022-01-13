using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text contador;
    private float Tiempo = 5f;
    Turnos hacerjugada = null;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = "Turno: " + Tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo-=Time.deltaTime;
        contador.text = "Turno: " + Tiempo.ToString("f0");
        if(Tiempo==0)
        {
            hacerjugada.MoveAllowed = false;
            Jugada.CambiarTurno();
            
        }
    }
}
