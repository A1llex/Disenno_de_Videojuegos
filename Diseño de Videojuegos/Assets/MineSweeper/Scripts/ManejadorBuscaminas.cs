using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorBuscaminas : MonoBehaviour{

    public Camera camara;
    void Update() {
        if (Input.GetMouseButtonDown(0)){
            Vector2 ubicaciónClick = new Vector2(camara.ScreenToWorldPoint(Input.mousePosition).x,
                camara.ScreenToWorldPoint(Input.mousePosition).y);
            ClickFichaPosición(ubicaciónClick);
        }
    }

    /// <summary>
    /// Intenta hacer click en la ficha con la posición dada
    /// </summary>
    /// <param name="posición"></param>
    public void ClickFichaPosición(Vector3 posición){
        RaycastHit2D hit = Physics2D.Raycast(posición, Vector2.zero, 0f);
        if (hit){
            if (hit.collider.gameObject.TryGetComponent(out MosaicoBuscaminas mosaico)){
                mosaico.AlHacerClick();
            }
        }
    }
}
