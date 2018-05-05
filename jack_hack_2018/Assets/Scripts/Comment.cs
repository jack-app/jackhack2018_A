using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comment : MonoBehaviour {

	private MainController MC;
	public PostData PD;

	void Awake(){
		MC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<MainController> ();
		gameObject.GetComponent<Text> ().text = PD.pComment [MC.PlayingID];
	}

	void Update(){
		
	}
}
