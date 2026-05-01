using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // and se escribe &&
        // or se escribe ||
        // falso es 0 y verdadero es 1
//  A B C     OR   AND ((A or b) and c)
//  1 1 1     1     1         1
//  1 1 0     1     0         0
//  1 0 1     1     0         1
//  1 0 0     1     0         0
//  0 1 1     1     0         1
//  0 1 0     1     0         0
//  0 0 1     1     0         0
//  0 0 0     0     0         0

        variable1 = true;
        variable2 = false; 
        variable3 = false;
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operacion 1 es verdadera");
        }
        else if ((variable1 || variable2) || variable3)
        {
            Debug.Log("La operacion 2 es verdadera");  
        }
        else if((variable3 && variable2) || variable1)
        {
            Debug.Log("La operacion 3 es verdadera");
        }
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        // ctrl K + ctrl C para comentar lo seleccionado
        // if (valor1 >= 0)
        // {
        //     Debug.Log("el valor es positivo");
        // }
        // else
        // {
        //     Debug.Log("el valor es negativo");
        

        string resultado = (valor1>=0) ? "el valor es positivo" : "El valor es negativo";
        Debug.Log (resultado);
;    //    switch (valor1)
    //    {
    //      case (int) SeleccionColor.rojo:
    //        Debug.Log("El color es rojo");
    //        break;
    //        case (int) SeleccionColor.verde:
    //        Debug.Log("El color es verde");
    //        break;
    //        case (int) SeleccionColor.azul:
    //        Debug.Log("El color es azul");
    //       break;
    //      case (int) SeleccionColor.blanco:
    //      Debug.Log("El color es blanco");
    //      break;
    //      case (int) SeleccionColor.gris:
    //      Debug.Log("El color es gris");
    //      break;
    //  default:
    //      Debug.Log("Ese color no es valido");
    //      break;
    //  }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
