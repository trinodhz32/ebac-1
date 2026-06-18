using UnityEngine;

public class Ciclos : MonoBehaviour
{
    //for       => sabemos cuantas veces vamos a repetir el ciclo
    //while     => no sabemos cuantas veces vamos a repetir el ciclo
    //do while  => al menos una vez si se ejecutara
    //arreglos  => [0,1,2,3,4]
    //arreglos multidimensionales
    //    =>[0,1,2]
    //      [3,4,5]
    //      [6,7,8]
    //arreglos jagged
    //      =>[0,1,2,3,4]
    //        [6,7]
    //        [8,9,10]
    //foreach
    
    int contador = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] miArreglo = new int[5];
        miArreglo = new int[7]; 
        string[] diaSemana = new string[7] { "lunes","martes","miercoles","jueves","viernes","sabado","domingo" };
        for (int i = 0; i < diaSemana.Length; i++)
        {
            Debug.Log(diaSemana[i]);
        }        
        // Debug.Log(diaSemana[0]);
        // Debug.Log(diaSemana[1]);
        // Debug.Log(diaSemana[2]);
        // Debug.Log(diaSemana[3]);
        // Debug.Log(diaSemana[4]);
        // Debug.Log(diaSemana[5]);
        // Debug.Log(diaSemana[6]);

        int[,] miMatriz = new int[3, 3]{{1,2,3},{4,5,6},{7,8,9}};
        for(int j = 0; j < miMatriz.GetLength(1); j++) 
        {
            for (int k = 0; k < miMatriz.GetLength(1); k++)
            {
                miMatriz[j, k] += 1;
                Debug.Log(miMatriz[j, k]);
            }
        }
    

        //  for(int i=0; i <= 10; i++)
        // {
        //      Debug.Log(i);
        // }
        bool miBooleano = false;
        // while (miBooleano)
        // {
        //     contador++;
        //     Debug.Log("Hola");
        // }

        // do
        // {
        // Debug.Log("Hola desde el do while");
        // }while (miBooleano);
        }

    // Update is called once per frame
    void Update()
    {
        // contador++;
        // Debug.Log(contador);
    }
}
  