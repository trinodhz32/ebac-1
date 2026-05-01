using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiva3 : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    public Primitiva1 primergo;
    public Primitiva2 segundogo;
    public bool resultadoAND;



        //    private Color[] TresColores = { Color.red, Color.green, Color.blue };
           
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

void FixedUpdate()
{
    
    bool valor1 = primergo.EsVerdadero;
    bool valor2 = segundogo.EsFalso;
    resultadoAND = valor1 && valor2;
    _meshRenderer = GetComponent<MeshRenderer>();

    if (resultadoAND)
    {
        _meshRenderer.material.color = Color.white;
        Debug.Log("Es verdadero primitiva 3");
    }
    else
    {
        _meshRenderer.material.color = Color.black;
        Debug.Log("Es falsa primitiva 3");
    }
}
   
    
}
 