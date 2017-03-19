using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberGen : MonoBehaviour {

	[SerializeField]private List<int> _ints = new List<int>();
	[SerializeField]private List<TextMesh> _text = new List<TextMesh>();
	[SerializeField]private TextMesh textInst;
	[SerializeField]private int spawnAmount;
	private Vector3 _place;
	int randomNumb;

	void Update(){

	}

	void Start(){
		for (int i = 0; i < _ints.Count; i++) {
			_ints [i] = i;
		}
		for (int i = 0; i < 9; i++) {
			for (int j = 1; j < spawnAmount + 1; j++) {
				_place = new Vector3 (_text[i].transform.position.x + j, _text [i].transform.position.y, _text[i].transform.position.z);
				TextMesh obj = Instantiate (textInst, _place, Quaternion.identity);
				_text.Add (obj);
			}
		}
		for (int i = 0; i < _text.Count; i++) {
			randomNumb = Random.Range (0, _ints.Count);
			_text [i].text = ("" + _ints[randomNumb]);
			_ints.RemoveAt (randomNumb);
		}
	}

}
