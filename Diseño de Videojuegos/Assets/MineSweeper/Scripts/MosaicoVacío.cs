using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosaicoVacío : MosaicoBuscaminas
{
	public Sprite[] spritesNumeros;

	public override int AlHacerClick(){
		Debug.Log("Mosaico vacío pulsado");
		int numerodeminasalrededor = CalculaMinasAlrededor();
		spriteSuperior.SetActive(false);
		return CODIGO_VACIO;
	}

	public int CalculaMinasAlrededor(){
		return 1;
	}

	public void CambiaSprite(int numero){
		GetComponent<SpriteRender>().sprite=spritesNumeros[numero]
		retunr;
	}

}
