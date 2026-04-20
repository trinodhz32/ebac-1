using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("algo paso");

        Debug.LogWarning("Algo mediana mente mal");
        Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
       // x = x + 1;
        // Debug.Log(x);

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("gola desde fixed update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde late update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto a sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitaado");
    }
} 
