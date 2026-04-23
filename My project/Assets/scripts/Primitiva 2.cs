using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiva2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = colorAleatorio;
       
    }
}
