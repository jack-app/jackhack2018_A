using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayPropa : MonoBehaviour {

	public PostData PD;

	public GameObject Tameta;

	public GameObject PlayImage;

	private string FilePath;

	private MainController MC;
	private int pID;

	// Use this for initialization
	void Awake () {
		MC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<MainController> ();
	}

	void OnEnable(){
		Play ();
	}

	public void Play(){
		pID = MC.PlayingID;
		StartCoroutine (PlayCoroutine (pID));
	}

	public IEnumerator PlayCoroutine(int pID){
		FilePath = "https://mb.api.cloud.nifty.com/2013-09-01/applications/m7nuO4BUVd6Shmm9/publicFiles/" + PD.pFileName [pID];
		Debug.Log (FilePath);

		WWW www = new WWW(FilePath);

		yield return www;

		switch (PD.pType [pID]) {
		case "image":
			// webサーバから取得した画像をRaw Imagで表示する
			RawImage rawImage = PlayImage.GetComponent<RawImage> ();
			rawImage.texture = www.textureNonReadable;
			break;
		case "music":
			break;
		}

		yield return new WaitForSeconds (int.Parse(PD.pPlayTime[pID]));

		Tameta.SetActive (true);
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
