using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiva3 : MonoBehaviour
{
           private Color[] TresColores = { Color.red, Color.green, Color.blue };
           
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        int indiceAleatorio = Random.Range(0, TresColores.Length);
        GetComponent<MeshRenderer>().material.color = TresColores[indiceAleatorio];
    }
}
