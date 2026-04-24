using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;
    float miDecimal = 1.0f;
    float primerDigito = 2.45f;
    float segundoDigito = 3.68f;
    int resultadoFInal;
    private MeshRenderer meshRenderer8;
    string mensaje;
    float noDecimal = 3.14159265f;
    string animal = "Leon marino de agua dulce";
    string resultado = "";
    string borrare = "Yo no soy trino";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        string final8 = borrare.Substring(5);
        Debug.Log(final8);

        for (int modulo8 = 0; modulo8 < animal.Length; modulo8++)
        {
            if (modulo8 % 2 == 0)
            { 
                resultado += animal[modulo8];
            }
        }
        Debug.Log("Caracteresque son pares : " + resultado);


        string milString1 = "3500";
        string milString2 = "1200";

        int milNumero1;
        int milNumero2;

        bool exito1 = int.TryParse(milString1, out milNumero1);
        bool exito2 = int.TryParse(milString2, out milNumero2);

        if (exito1 && exito2)
        {
            int suma = milNumero1 + milNumero2;
            Debug.Log("La suma es: " + suma);
        }
        else
        {
            Debug.LogError("Uno o ambos valores no son números válidos de mil.");
        }

        string segundoNombre = "Santiago";
        string primerNombre = "Trino";
        string misApellidos = "Diaz Hernandez";
         string salida = $"Mi nombre es: {primerNombre} {segundoNombre} y mis Apellidos son {misApellidos}";
        Debug.Log(salida);

        string losDecimales = noDecimal.ToString();
        string primerosDecimales = losDecimales.Substring(0, 6);
        Debug.Log(primerosDecimales);

        meshRenderer8 = GetComponent<MeshRenderer>();

        segundoDigito = (int)segundoDigito;
        primerDigito = (int)primerDigito;
        resultadoFInal = (int)primerDigito + (int)segundoDigito;
    if (resultadoFInal % 2 == 0)
            mensaje = "el numero " + resultadoFInal + " es par";
        else
            mensaje = "el numero " + resultadoFInal + " es non";

        Debug.Log(mensaje);
    }

    // Update is called once per frame
    void Update()
    {
       // miLong += 2;
        //Debug.Log (miLong);
    }

    private void FixedUpdate()
    {
      //  miDecimal *= 1.1f;
       // Debug.Log(miDecimal);

                switch (mensaje)
        {
            case string s when s.Contains("es par"):
                meshRenderer8.material.color = Color.blue;
                break;
            case string s when s.Contains("es non"):
                meshRenderer8.material.color = Color.green;
                break;
            default:
                meshRenderer8.material.color = Color.white;
                break;
        } 
    }
}