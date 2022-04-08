using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;

    public int dinero;

    int precioT;
    // Start is called before the first frame update
    void Start()
    {
        precioT = precio1 + precio2 + precio3;

        if (precioT > dinero)
        {
            int falta = precioT - dinero; 
            Debug.Log("No alcanza el dinero, faltan " + falta + " pesos");
        }
        else if (precioT < dinero)
        {
            int sobra = dinero - precioT;
            Debug.Log("Alcanza y sobran " + sobra + "pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
