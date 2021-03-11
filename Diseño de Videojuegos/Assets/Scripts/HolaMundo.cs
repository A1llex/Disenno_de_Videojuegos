using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private int numeroCuadro;

    public int Suma(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
    // Start is called before the first frame update
    void Start()    {
        Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            GetComponent<Transform>().position += Vector3.up;
        }
    }
}