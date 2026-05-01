using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiva2 : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
public bool EsFalso = true;
 int valor1 = 1;
    int limiteInferior = -1;
    int limiteSuperior = 1;
    enum SeleccionColor
    {
        negro,
        blanco
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        //   Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        // GetComponent<MeshRenderer>().material.color = colorAleatorio;
       
    }
    private void FixedUpdate(){
_meshRenderer = GetComponent<MeshRenderer>();
    EsFalso = !EsFalso;
    if (EsFalso == true)
    {
        _meshRenderer.material.color = Color.white;
        Debug.Log("la primitiva 2 es verdadera");
    }
        else 
        {
            _meshRenderer.material.color = Color.black;
            Debug.Log("la primitiva 2 es falsa");
        }
              valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1); 
    }
}
