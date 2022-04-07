using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // 1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda 
    //si son iguales o no lo son.
    public int num1, num2;
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Son numeros iguales");
        }
        else
        {
            Debug.Log("No son iguales");
        }
    }

    
}
