using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
        char c = '6';
        int valorEntero = 0;
       if (!int.TryParse(c.ToString(), out valorEntero))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde casa de shari";
        string miSegundoString = miString.Replace('e', 'E');
        string miCuartioString = miString.ToUpper();
        string miTercerString = miString + " " + miSegundoString;
        string ejemploEscape = "c:\\Users\\Trino\\Assets";
        string miNombre = "Trino";
        string misApellidos = "Diaz Hernandez";
        string primerApellido = misApellidos.Substring(0, 4);
        string salida = $"Mi nombre es: {miNombre} y mis Apellidos son {misApellidos}";
        miCaracter = miString[3];
        int longitud = miString.Length;
        Debug.Log(ejemploEscape);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
