using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Takarakuji : MonoBehaviour {
	public GameObject Atari;
	public GameObject Hazure;
	public UserData UD;
    public Text text;
    public Text Text;
    public Text texth;
	void Start(){
        
		int r = Random.Range (0, 2);
		switch (r) {
		case 0:
			Atari.SetActive (true);
                int getpoint = 10 + Random.Range(0, 31415);
                UD.money += getpoint;
                text.text = getpoint + "P獲得！";
                Text.text = "現在 " + UD.money + "P";
			break;
		case 1:
			Hazure.SetActive (true);
                texth.text= "現在 " + UD.money + "P";
                break;
		}

	}
}
