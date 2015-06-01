using UnityEngine;
using System.Collections;

public class ColliderDestroy : MonoBehaviour {

	void OnTriggerEnter(Collider GameObjectColetaveis) {
		Destroy(GameObjectColetaveis.gameObject);
	}
}