using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BingoCheck : MonoBehaviour {
	[SerializeField]private List<GameObject> dots = new List<GameObject>();
	void OnTriggerEnter(Collider dot){
		dots.Add (dot.gameObject);
		if (dots.Count == 11) {
			for (int i = 0; i < dots.Count; i++) {
				dots[i].GetComponent<Renderer> ().material.color = Color.red;
			}
		}
	}
}
