using UnityEngine;

public class EstructurasDatos : MonoBehaviour
{
    List <int> listaNumeros = new list<int>();
    List <string> listaStrings = new List<string>();
    HashSet <int> hashSetInts = new HashSet<int>();
    Queue <string> colaStrings = new Queue<string>();
    Stack <string> pilaStrings = new Stack<string>();
    Dictionary <string, float> poderArmas = new Dictionary<string, float>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(1);
        }
        foreach(var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaStrings.Add("Chari");
        listaStrings.Add("Rulo");
        listaStrings.Add("Julia");
        listaStrings.Add("Micho");
        listaStrings.Add("Trino");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        listaStrings.RemoveAt(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
