using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerCodigo : MonoBehaviour
{

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;
    //Variables
    //El Tipo de Dato y Nombre
    int numeroDeSaltos = 0;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* private void OnCollisionEnter(Collision infoChoque)
    {
        numeroDeSaltos = numeroDeSaltos + 1;
        Debug.Log("Numero de Choques: " + numeroDeSaltos + " " +gameObject.name + " contra " + infoChoque.gameObject.name);
        if (numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name +" Ha chocado "+ numeroDeSaltos + " veces contra " + infoChoque.gameObject.name);
            if (numeroDeSaltos == 15)
            {
                Debug.Log("Victoria");
            }
        }
       

    }
    */
}