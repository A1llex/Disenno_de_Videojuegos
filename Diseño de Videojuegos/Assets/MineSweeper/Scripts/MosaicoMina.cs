using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosaicoMina : MosaicoBuscaminas
{

    public override int AlHacerClick(){
        Debug.Log("Mosaico con mina pulsado");
        spriteSuperior.SetActive(false);
        return CODIGO_MINA;
    }
}
