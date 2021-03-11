using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTiempo : MonoBehaviour {
    
    private float tiempotranscurrido;

    // Update is called once per frame
    void Update()
    {
        tiempotranscurrido += Time.deltaTime;
        transform.position = new Vector3(transform.position.x,Mathf.Sin(tiempotranscurrido),transform.position.z);
    }
}
