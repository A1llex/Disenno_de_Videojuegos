using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Tablero que controla el flujo de juego del buscaminas
/// </summary>
public class TableroBuscaminas{
    public MosaicoBuscaminas[][] tablero;

    public TableroBuscaminas(MosaicoBuscaminas[][] nuevoTablero){
        tablero = nuevoTablero;
    }

}
