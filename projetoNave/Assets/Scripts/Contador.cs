using UnityEngine;
using System.Collections;

public class Contador : MonoBehaviour {

	public static int pontos;
	public GUIText pontostext;
	void Start (){
		pontos = 0;
	}
	void Update (){
		pontostext.text = "PONTOS:" + pontos;
	}
}