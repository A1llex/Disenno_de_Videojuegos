using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    private float tiempotranscurrido;
    void Start() {
    }

     void Update()
    {
        tiempotranscurrido += Time.deltaTime;
        if (tiempotranscurrido > 5)
        {
            Debug.Log("Han pasado 5 segundos");
        }
    }
}
