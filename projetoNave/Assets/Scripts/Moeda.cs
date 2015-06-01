using UnityEngine;
using System.Collections;

public class Moeda : MonoBehaviour {

	void OnTriggerEnter () {
		//Contador.pontos = Contador.pontos + 1;
		Contador.pontos ++;
		// Destroy (gameObject);
	}
}
