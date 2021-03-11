using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MosaicoBuscaminas : MonoBehaviour{

    private TableroBuscaminas tablero;

    /// <summary>
    /// Posición del mosaico en el tablero
    /// </summary>
    private Vector2Int posiciónTablero;

    /// <summary>
    /// Código que devuelve el mosaico al ser pulsado
    /// </summary>
    /// <returns></returns>
    public abstract int AlHacerClick();

    /// <summary>
    /// Sprite que oculta lo que hay bajo este mosaico
    /// </summary>
    public GameObject spriteSuperior;

    /// <summary>
    /// Posible estado del mosaico
    /// </summary>
    public int estado;

    public static int NO_EXPLORAD = 0, EXPLORADO = 1;

    public static int CODIGO_MINA = 0, CODIGO_VACIO = 1;

    public void Inicializar(TableroBuscaminas nuevoTablero, Vector2Int nuevaPosición){
        tablero = nuevoTablero;
        posiciónTablero = nuevaPosición;
    }
}
