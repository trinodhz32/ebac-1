using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EstructurasDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<string> hashSetStrings = new HashSet<string>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            DemoDictionary("escopeta");
            DemoDictionary("espada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HashSet()
    {
    HashSet<int> hashSetInts = new HashSet<int>();


        for (int i = 0; i < 20; i++) 
        {
            hashSetInts.Add(i);
        }

        if (hashSetInts.Contains(5)) 
        {
            hashSetInts.Remove(5);
        }
        else 
        {
            Debug.Log("El HashSet no contiene este elemento");
        }
    }
    public void DemoColas()
    {
        Queue<string> colaStrings = new Queue<string>();

        // FIFO => First In First Out
        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");

        Debug.Log(colaStrings.Peek()); // Muestra el primero sin sacarlo
        colaStrings.Dequeue();          // Saca al primero de la fila

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();

        Debug.Log(colaStrings.Peek());
    }

    public void DemoDictionary(string arma)
{
   
    float temporal = 0; 
    if (!poderArmas.ContainsKey("rifle"))
        {
                poderArmas.Add("rifle", 7.0f); 
        }
        if (!poderArmas.ContainsKey("pistola"))
        {
                poderArmas.Add("pistola", 3.0f); 
        }
            if (!poderArmas.ContainsKey("escopeta"))
        {
                poderArmas.Add("escopeta", 5.0f); 
        }
            if (!poderArmas.ContainsKey("francotirador"))
        {
                poderArmas.Add("francotirador", 10.0f); 
        }
            if (!poderArmas.ContainsKey("cuchillo"))
        {
                poderArmas.Add("cuchillo", 2.0f); 
        }


    
    if (poderArmas.TryGetValue("escopeta", out temporal)) 
    {
        Debug.Log(temporal); 
    }
    else 
    {
        Debug.Log("Esa arma no existe"); 
    }
}

public void Pilas()
{
    // Declaración previa: Stack<string> pilaStrings = new Stack<string>();
    // Lógica: First In Last Out => FILO

    pilaStrings.Push("As"); 
    pilaStrings.Push("CincoEspadas"); 
    pilaStrings.Push("TresCorazones"); 
    pilaStrings.Push("CuatroTrebol"); 
    pilaStrings.Push("ReyEspadas"); 

    Debug.Log(pilaStrings.Peek()); 
    pilaStrings.Pop(); 

    Debug.Log(pilaStrings.Peek()); 
    pilaStrings.Pop(); 

    Debug.Log(pilaStrings.Peek()); 
    pilaStrings.Pop(); 

    Debug.Log(pilaStrings.Peek()); 
    pilaStrings.Pop(); 
}
public void lista()
    {
         for (int i = 0; i < 10; i++)
    {
        listaNumeros.Add(Random.Range(0, 20));
    }

    foreach (var numero in listaNumeros)
    {
        Debug.Log(numero);
    }

    //listaNumeros.Sort();
    var listaOrdenada = listaNumeros.OrderBy(p => p).ToList();
    var listaConValoresGrandes = listaNumeros.Where(p => p > 10).ToList();
    var QueyLinq = listaNumeros;
    Debug.Log(listaNumeros);

    foreach (var numero in listaNumeros)
    {
        Debug.Log(numero);
    }

    Debug.Log("lista de numeros ordenada");
    foreach (var numero in listaOrdenada)
    {
        Debug.Log(numero);
    }
        Debug.Log("lista de numeros grandes");
    foreach (var numero in listaConValoresGrandes)
    {
        Debug.Log(numero);
    }
        //         for (int i = 0; i < 20; i++)
        // {
        //     listaNumeros.Add(1);
        // }
        // foreach(var numero in listaNumeros)
        // {
        //     Debug.Log(numero);
        // }
        // listaStrings.Add("Chari");
        // listaStrings.Add("Rulo");
        // listaStrings.Add("Julia");
        // listaStrings.Add("Micho");
        // listaStrings.Add("Trino");
        // foreach (var nombre in listaStrings)
        // {
        //     Debug.Log(nombre);
        // }
        // listaStrings.RemoveAt(2);
    }
}
