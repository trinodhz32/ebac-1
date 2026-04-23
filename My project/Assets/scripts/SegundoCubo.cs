using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoCubo : MonoBehaviour
{
     public GameObject PrefabCubo;
    public List<GameObject> ElSegundoCubo;
    public float factorDeEscalamiento;
    public int numCubos = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ElSegundoCubo = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
      
        numCubos++;
    GameObject tempGameObject = Instantiate(PrefabCubo);
    tempGameObject.name = "CuboNumero " + numCubos;

    Color c = new Color(Random.value, Random.value, Random.value);
    tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    tempGameObject.transform.position = Random.insideUnitSphere;

    ElSegundoCubo.Add(tempGameObject);

    List<GameObject> objetosParaEliminar = new List<GameObject>();

    foreach (GameObject go in ElSegundoCubo)
    {
        float escala = go.transform.localScale.x;
        escala *= factorDeEscalamiento;
        go.transform.localScale = Vector3.one * escala;

        if (escala <= 0.1f)
        {
            objetosParaEliminar.Add(go);
        }
    }

    foreach (GameObject go in objetosParaEliminar)
    {
        ElSegundoCubo.Remove(go);
        Destroy(go);
    }
    }
}
