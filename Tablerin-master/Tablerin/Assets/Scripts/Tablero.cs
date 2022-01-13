using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{
    public Transform casillero1;
    public int gridAncho;
    public int gridAltura;

    public int jugadores;

    float casilleroAltura= 1.732f;
    float casilleroAncho= 2.0f; 

    public float gap = 0.0f;

    Vector3 startPos;

    void Start(){
        switch (jugadores)
        {
            case 2:
                gridAltura = 11;
                gridAncho = 11;
                break;
            case 4:
                gridAltura = 22;
                gridAncho = 22;
                break;
            default:
        }
        añadirGap();
        calcStartPos();
        crearGrid();

    }

    void añadirGap(){
        casilleroAltura += casilleroAltura * gap;
        casilleroAncho += casilleroAncho * gap;
    }

    void calcStartPos(){
        float offset=0;
        if(gridAltura/2 % 2 != 0){
            offset= casilleroAncho/2;
        }
        float x = -casilleroAncho * (gridAncho/2)- offset;
        float z = casilleroAltura * 0.75f * (gridAltura/2);

        startPos = new Vector3(x,0,z);
    }

    Vector3 calcWorldPos(Vector2 gridPos){
        float offset = 0;
        if(gridPos.y %2 !=0){
            offset = casilleroAncho/2;
        }
        float x = startPos.x + gridPos.x * casilleroAncho + offset;
        float z = startPos.z + gridPos.y * casilleroAltura + 0.75f;

        return new Vector3(x,0,z);

    }

    void crearGrid(){
        for (int y = 0; y < gridAltura; y++){
            for (int x = 0; x < gridAncho; x++){
                Transform casillero = Instantiate(casillero1) as Transform;
                Vector2 gridPos = new Vector2(x,y);
                casillero.position = calcWorldPos(gridPos);
                casillero.parent= this.transform;
                casillero.name = "Casillero" + x +"|" + y;
    
                }   

            }
    }
}
