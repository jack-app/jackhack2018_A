using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takarakuji : MonoBehaviour {
	public GameObject Atari;
	public GameObject Hazure;
	public UserData UD;

	void Start(){
		int r = Random.Range (0, 2);
		switch (r) {
		case 0:
			Atari.SetActive (true);
			UD.money += 65536;
			break;
		case 1:
			Hazure.SetActive (true);
			break;
		}
	}
}
