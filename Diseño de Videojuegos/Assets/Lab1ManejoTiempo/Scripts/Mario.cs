using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{

    public int salud;
    
    public float velocidad;

    public Sprite[] spritesSalud;

    public bool invulnerable;

    private Animator animador;

    private bool puedeMoverse;
    // Start is called before the first frame update
    void Start(){
        puedeMoverse = true;
        animador = GetComponent<Animator>();
        Component[] componentes = GetComponents(typeof(Component)); 
        foreach (Component c in componentes)
        {
            Debug.Log(c.ToString());
        }
    }

    private void Update(){
        if (puedeMoverse){
            if (Input.GetKey(KeyCode.A)){
                GetComponentInChildren<SpriteRenderer>().flipX = true;
                transform.position += Vector3.left * velocidad * Time.deltaTime;
                animador.SetBool("Caminando",true);
            } else if (Input.GetKey(KeyCode.D)) {
                GetComponentInChildren<SpriteRenderer>().flipX = false;
                transform.position += Vector3.right * velocidad * Time.deltaTime;
                animador.SetBool("Caminando",true);
            } else {
                animador.SetBool("Caminando",false);
            }
        }
    }

    public void OnSaludCero(){
        DesemparentarCámara();
        puedeMoverse = false;
        StartCoroutine(GanaInvulnerabilidad(10f));
        animador.SetTrigger("Morir");
    }

    public void DesemparentarCámara(){
        GetComponentInChildren<Camera>().gameObject.transform.parent = null;
    }

    /// <summary>
    /// Gana invulnerabilidad por t segundos
    /// </summary>
    /// <returns></returns>
    public IEnumerator GanaInvulnerabilidad(float t) {
        invulnerable = true;
        yield return new WaitForSeconds(t);
        invulnerable = false;
    }

    public void ActualizaSalud() {
        GetComponent<SpriteRenderer>().sprite = spritesSalud[salud];
    }

    public void TomaDano(int dano) {
        if (!invulnerable) {
            salud -= dano;
            if (salud == 0){
              OnSaludCero();  
            } else{
                StartCoroutine(GanaInvulnerabilidad(5f));
                ActualizaSalud();
            }
        }
    }
}
