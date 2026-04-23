using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitiva1 : MonoBehaviour
{
    public static GameObject primitiva1;
    private void Awake()
    {
                Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = colorAleatorio;
       
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
