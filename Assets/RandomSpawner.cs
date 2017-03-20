using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {
	private RandomNumberGen randomNumberGen;
	private float timer;
	private int randomNumb;
	[SerializeField]private List<int> dots = new List<int>();
	[SerializeField]private float maxTimer;
	[SerializeField]private GameObject dot;
	[SerializeField]private int numberAmount = 99;
	[SerializeField]private float xOffset;
	[SerializeField]private float yOffset;
	void Start () {
		randomNumberGen = GetComponent<RandomNumberGen> ();
		timer = maxTimer;
		for (int i = 0; i < randomNumberGen.getText.Count; i++) {
			dots.Add (i);
		}
	}
	void Update () {
		timer -= Time.fixedDeltaTime;
		if (timer < 0) {
			timer = maxTimer;
			Spawn ();
		}
	}
	void Spawn(){
		if (dots.Count > 0) {
			randomNumb = Random.Range (0, dots.Count);
			Instantiate (dot, new Vector3 (randomNumberGen.getText [dots [randomNumb]].transform.position.x + xOffset, randomNumberGen.getText [dots [randomNumb]].transform.position.y + yOffset, randomNumberGen.getText [dots [randomNumb]].transform.position.z), Quaternion.identity);
			dots.RemoveAt (randomNumb);
		}
	}
}
