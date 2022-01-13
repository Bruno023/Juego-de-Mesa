using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugada : MonoBehaviour
{

    private static int turno = 1;
    private static Turnos hacerjugada=null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void CambiarTurno()
    {
        if (turno == 1)
        {
            hacerjugada.MoveAllowed = true;
        }
        else if (turno == -1)
        {
            hacerjugada.MoveAllowed = true;
        }
        turno *= -1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}

