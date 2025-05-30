﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptExamenJero : MonoBehaviour
{
    public int entradaBasica;
    public int entradaNormal;
    public int entradaPremium;
    private int precio;
    public string codigoEntrada;
    public bool Agregado;
    private int precioAgregado;
    private int porcentaje = 15;
    private int decimalPorcentaje;
    private int valorPorcentaje;
    private int resultado;
    // Start is called before the first frame update
    void Start()

    {
        
        if (entradaBasica < 0 || entradaNormal < 0 || entradaPremium < 0)
        {
            Debug.Log("No se puede comprar esa cantidad de entradas, tienes que poner un número positivo");
            return;
        }
       if (entradaBasica > 4 || entradaNormal > 6)
        {
            Debug.Log("No se puede comprar esa cantidad de entradas");
            return;
        }
        if(codigoEntrada == "B")
        {
            precio = entradaBasica * 800;
            Debug.Log("Compraste la entrada " + codigoEntrada + " una cantidad de " + entradaBasica + " Tenes que pagar " + precio + " pesos por las entradas");
            return;
    }
        else if (codigoEntrada == "N")
        {
            precio = entradaNormal * 1200;
            Debug.Log("Compraste la entrada " + codigoEntrada + " una cantidad de " + entradaNormal + " Tenes que pagar " + precio + " pesos por las entradas");
            return;
        }
        else if (codigoEntrada == "P" && Agregado == true)
        {

            precio = entradaPremium * 2000;
            decimalPorcentaje = 15 / 100;
            valorPorcentaje = precio * decimalPorcentaje;
            resultado = precio + valorPorcentaje;
            Debug.Log("Compraste la entrada " + codigoEntrada + " una cantidad de " + entradaPremium + " Tenes que pagar " + resultado + " pesos por las entradas");
            return;
        }
        else if (codigoEntrada == "P")
        {
            precio = entradaPremium * 2000;
            Debug.Log("Compraste la entrada " + codigoEntrada + " una cantidad de " + entradaPremium + " Tenes que pagar " + precio + " pesos por las entradas");
            return;
        }
      
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
