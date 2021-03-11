using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;

    public float x, y;


    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal"); //Obtenemos el valor del personaje en el eje x
        y = Input.GetAxis("Vertical");//Obtenemos el valor del personaje en el eje y

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion,0); //Forma en la cual haremos rotar al personaje
        transform.Translate(0,0,y*Time.deltaTime*velocidadMovimiento); //Forma en la que moveremos al personaje
    }
}
