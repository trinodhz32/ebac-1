using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableNumericos : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("El valor de miByteConSigno es: "+ miByteConSigno);
        Debug.Log("El valor de miInt es: " + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log ("El valor de mi intSinSigno es : "+ miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("El valor de miInt es :" + miInt);

        int a, b, c;
        float f;
        a=5;
        b=10;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a / b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);
        miInt = Random.Range(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("el numero " + miInt + " es par");
        }
        else
        {
            Debug.Log("el numero " + miInt + " es non");
        }

    }

    // Update is called once per frame
    void Update()
    {
        miLong += 2;
        Debug.Log (miLong);
    }
}
