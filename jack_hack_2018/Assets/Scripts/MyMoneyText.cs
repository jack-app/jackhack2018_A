using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyMoneyText : MonoBehaviour {

	private Text txt;
	public UserData UD;

	void Awake(){
		txt = gameObject.GetComponent<Text> ();
	}

	void Update(){
		txt.text = UD.money.ToString ();
	}
}
