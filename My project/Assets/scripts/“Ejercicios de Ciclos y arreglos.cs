using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    int contador = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int[] primerArreglo = new int[5];
        string[] Clima = new string[5] { "11", "12", "13", "14", "15"};
         for (int i = 0; i < Clima.Length; i++)                  //una dimension
         {
        Debug.Log(Clima[i]);
         }        


         int[] segundoArreglo = new int[5];
        string[] Personas = new string[5] { "22", "23", "24", "26", "27"};
         for (int i = 0; i < Personas.Length; i++)                  //una dimension
         {
        Debug.Log(Personas[i]);
         }        

        int[] tercerArreglo = new int[primerArreglo.Length];

        for (int i = 0; i < primerArreglo.Length; i++)
        {
        tercerArreglo[i] = primerArreglo[i] + segundoArreglo[i];
        }

        string[] Nombres = { "Rulo", "Micho", "Julia", "Chari", "Abuelita", "Yeshua", "MIMI" };
        string nombresUnidos = "";

        foreach (string nombre in Nombres)
        {
        nombresUnidos += nombre + " ";
        }

        Debug.Log(nombresUnidos.Trim());


        int[,] Parte3 = {
            {31, 32, 33},
            {34, 35, 36}
        };

        int[] vector = {10, 20, 30};

        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++) 
        {
            int suma = 0;
            for (int j = 0; j < 3; j++) 
            {
                suma += Parte3[i, j] * vector[j];
            }
            resultado[i] = suma;
        }
        for (int i = 0; i < resultado.Length; i++)
        {
            Debug.Log("Resultado[" + i + "] = " + resultado[i]);
        }
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
