using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFrame : MonoBehaviour
{

    private float tiempotranscurrido;

    public float velocidad;

    // Update is called once per frame
    void Update()
    {
        tiempotranscurrido += velocidad*Time.deltaTime;
        transform.position = new Vector3(transform.position.x,Mathf.Sin(tiempotranscurrido),transform.position.z);
    }
}
