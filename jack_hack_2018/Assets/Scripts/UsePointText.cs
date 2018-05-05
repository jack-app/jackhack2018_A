using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsePointText : MonoBehaviour {

	public InputField ifPlayCount;
	public InputField ifPlayTime;
	public UserData UD;
	private Text text;

	void Awake(){
		text = gameObject.GetComponent<Text> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ifPlayCount.text != "" && ifPlayTime.text != "") {
			int usep = int.Parse (ifPlayCount.text) * int.Parse (ifPlayTime.text);
			text.text =usep.ToString ();
			UD.money -= usep;
		}
	}
}
