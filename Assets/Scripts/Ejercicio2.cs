using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // 2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y
    //un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
    public float precio1, precio2, precio3, montodispo;
    void Start()
    {
        if (precio1 + precio2 + precio3 > montodispo)
        {
            Debug.Log("La suma de los productos supera el monto de dinero disponible");
            Debug.Log("Falta agregar $" + (precio1 + precio2 + precio3 - montodispo));
        }
        else if (precio1 + precio2 + precio3 <montodispo) {
            Debug.Log("La suma de los productos no supera el monto de dinero disponible");
            Debug.Log("Sobran $" + (montodispo - (precio1 + precio2 + precio3)));
        }

    }

    
}
