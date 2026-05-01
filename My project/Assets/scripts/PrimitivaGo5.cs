using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitivaGo5 : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    public Primitiva3 tercergo;
    public PrimitivaGo4 cuartogo;
    public bool resultado5;


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
    
    bool valor1 = tercergo.resultadoAND;
    bool valor2 = cuartogo.resultadoOr;
    resultado5 = valor1 || valor2;
    _meshRenderer = GetComponent<MeshRenderer>();

    if (resultado5)
    {
        _meshRenderer.material.color = Color.white;
        Debug.Log("Es verdadero primitiva 5");
    }
    else
    {
        _meshRenderer.material.color = Color.black;
        Debug.Log("Es falsa primitiva 5");
    }
}
   
    
}