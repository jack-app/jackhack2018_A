using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KokokuNode : MonoBehaviour {

	private MainController MC;

	public PostData PD;

	public RawImage Sumnail;
	public Text Title;
	public Button IntroButton;
	private Text Intro;

	public int pID;

	// Use this for initialization
	void Start () {
		MC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<MainController> ();
		Intro = MC.IntroText;
		Init ();
	}

	public void Init(){
		gameObject.GetComponent<Button> ().onClick.AddListener (ChangePanelToPlay);
		IntroButton.onClick.AddListener (SetIntroData);
		IntroButton.onClick.AddListener (DisplayIntro);
		StartCoroutine(InitCoroutine ());
	}

	IEnumerator InitCoroutine(){
		string FilePath = "https://mb.api.cloud.nifty.com/2013-09-01/applications/m7nuO4BUVd6Shmm9/publicFiles/" + PD.pSumnail[pID];

		WWW www = new WWW(FilePath);

		yield return www;

		// webサーバから取得した画像をRaw Imagで表示する(sumnail)
		Sumnail.texture = www.textureNonReadable;

		// title
		Title.text = PD.pTitle[pID];

	}

	public void ChangePanelToPlay(){
		MC.PlayingID = pID;
		MC.Play.SetActive (true);
		MC.Tameru.SetActive (false);
	}

	public void SetIntroData(){
		//intro
		Intro.text = PD.pIntro[pID];
	}

	public void DisplayIntro(){
		Intro.transform.parent.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
