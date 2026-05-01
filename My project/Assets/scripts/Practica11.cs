using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Practica11 : MonoBehaviour
{
    void Start()
    {
        var lista = GenerarLista(10, 1, 20);
        Debug.Log("Lista generada:");
        foreach (var n in lista)
            Debug.Log(n);

        int[] arreglo = { 5, 2, 9, 1, 7 };
        var ordenado = OrdenarDescendente(arreglo);

        Debug.Log("Arreglo ordenado descendente:");
        foreach (var n in ordenado)
            Debug.Log(n);

        List<int> repetidos = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        var sinRepetidos = QuitarRepetidos(repetidos);

        Debug.Log("Lista sin repetidos:");
        foreach (var n in sinRepetidos)
            Debug.Log(n);

        PilaACola();
    }

    public List<int> GenerarLista(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            lista.Add(Random.Range(rangoInferior, rangoSuperior));
        }

        return lista;
    }

    public int[] OrdenarDescendente(int[] arreglo)
    {
        return arreglo.OrderByDescending(x => x).ToArray();
    }

    public HashSet<int> QuitarRepetidos(List<int> lista)
    {
        return new HashSet<int>(lista);
    }

    public void PilaACola()
    {
        Stack<string> pila = new Stack<string>();

        pila.Push("Uno");
        pila.Push("Dos");
        pila.Push("Tres");

        Queue<string> cola = new Queue<string>();

        Debug.Log("Contenido de la pila:");

        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log(elemento);

            cola.Enqueue(elemento);
            pila.Pop();
        }

        Debug.Log("Contenido de la cola:");

        while (cola.Count > 0)
        {
            string elemento = cola.Peek();
            Debug.Log(elemento);

            cola.Dequeue();
        }
    }
}
    

