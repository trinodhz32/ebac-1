using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiva1 : MonoBehaviour
{

private MeshRenderer _meshRenderer;
public bool EsVerdadero = false;
 int valor1 = 1;
    int limiteInferior = -1;
    int limiteSuperior = 1;
    enum SeleccionColor
    {
        negro,
        blanco
    }
    private void Awake()

    {
        // Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        // GetComponent<MeshRenderer>().material.color = colorAleatorio;
       
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
               valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    _meshRenderer = GetComponent<MeshRenderer>();
    EsVerdadero = !EsVerdadero;
    if (EsVerdadero == true)
    {
        _meshRenderer.material.color = Color.white;
        Debug.Log("la primitiva 1 es verdadera");
    }
        else
        {
            _meshRenderer.material.color = Color.black;
            Debug.Log("la primitiva 1 es falsa");
        }

    }
}
