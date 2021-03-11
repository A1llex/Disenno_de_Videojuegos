using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTablero : MonoBehaviour{
    
    public int tamañoX, tamañoY;

    /// <summary>
    /// Ubicación en la que se comienza a generar el tablero
    /// </summary>
    public Transform ubicaciónInicialGeneración;

    /// <summary>
    /// Matriz que contiene todos los mosaicos del buscaminas
    /// </summary>
    private MosaicoBuscaminas[][] matrizMosaicos;

    public float anchoFicha, altoFicha = 0;

    /// <summary>
    /// Probabilidad de que un mosaico generado sea una mina
    /// </summary>
    public float probabilidadMina;

    private TableroBuscaminas tableroGenerado;

    public GameObject prefabMosaicoMina, prefabMosaicoVacío;

    private void Start(){
        StartCoroutine(GeneraTablero());
    }

    /// <summary>
    /// Genera un tablero con el tamaño contenido en este objeto
    /// </summary>
    /// <param name="tamX"></param>
    /// <param name="tamY"></param>
    public IEnumerator GeneraTablero(){
        // Se crea el objeto del que todas las fichas son hijas
        GameObject tableroObjeto = new GameObject("Tablero");
        tableroObjeto.transform.position = ubicaciónInicialGeneración.position;
        // Se empieza a generar la matriz de mosaicos
        matrizMosaicos = new MosaicoBuscaminas[tamañoX][];
        for (int i = 0; i < tamañoX; i++){
            MosaicoBuscaminas[] columnaMosaicos = new MosaicoBuscaminas[tamañoY];
            for (int j = 0; j < tamañoX; j++){
                //Genera una mina con la probabilidad dada en el objeto
                MosaicoBuscaminas nuevoMosaico = null;
                if (UnityEngine.Random.Range(0f, 1f) < probabilidadMina){
                    nuevoMosaico = GeneraMosaicoMina(i, j);
                } else {
                    nuevoMosaico = GeneraMosaicoVacío(i, j);
                }
                // Se emparenta al tablero y se asigna la referencia a la matriz
                nuevoMosaico.transform.parent = tableroObjeto.transform;
                columnaMosaicos[j] = nuevoMosaico;
                yield return new WaitForSeconds(0.1f);
            }
        }
        tableroGenerado = new TableroBuscaminas(matrizMosaicos);
    }

    /// <summary>
    /// Genera un mosaico vacío en la entrada dada
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public MosaicoVacío GeneraMosaicoVacío(int x, int y){
        Vector3 ubicaciónNuevoMosaico = ubicaciónInicialGeneración.position +
                                        (Vector3.right * x * anchoFicha) +
                                        (Vector3.down * y * altoFicha);
        GameObject nuevoMosaico = Instantiate(prefabMosaicoVacío, ubicaciónNuevoMosaico, new Quaternion());
        return nuevoMosaico.GetComponent<MosaicoVacío>();
    }
    
    /// <summary>
    /// Genera un mosaico con mina en la entrada dada
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public MosaicoMina GeneraMosaicoMina(int x, int y){
        Vector3 ubicaciónNuevoMosaico = ubicaciónInicialGeneración.position +
                                        (Vector3.right * x * anchoFicha) +
                                        (Vector3.down * y * altoFicha);
        GameObject nuevoMosaico = Instantiate(prefabMosaicoMina, ubicaciónNuevoMosaico, new Quaternion());
        return nuevoMosaico.GetComponent<MosaicoMina>();
    }
}
