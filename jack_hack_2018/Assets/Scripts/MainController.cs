﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	enum mState{
		Idle,ShowingMenuBar
	}

	public GameObject MenuBar;
	public GameObject UnderTabPanel;

	public GameObject Tameru;
	public GameObject Hiromeru;
	public GameObject Koukan;
	public GameObject MyPage;
	public GameObject Play;

	//SetActive関係でここに参照通しとく
	public Text IntroText;

	public int PlayingID;

	public MakeNodes MN;

	private mState state = mState.Idle;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<DataImpoter> ().Import ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 mPos = Camera.main.ScreenToViewportPoint (Input.mousePosition);
		switch (state) {
		case mState.Idle:
			break;
		case mState.ShowingMenuBar:
			if (Input.GetMouseButtonDown(0)&& mPos.x > 0.4) {
				HideMenuBar ();
			}
			break;
		}
	}

	public void ShowMenuBar(){
		UnderTabPanel.SetActive (true);
		MenuBar.GetComponent<Animator> ().SetBool ("ShowMenuBar",true);
		state = mState.ShowingMenuBar;
	}

	void HideMenuBar(){
		UnderTabPanel.SetActive (false);
		MenuBar.GetComponent<Animator> ().SetBool ("ShowMenuBar",false);
		state = mState.Idle;
	}

	public void ChangeMenuBarState(){
		switch (state) {
		case mState.Idle:
			ShowMenuBar ();
			break;
		case mState.ShowingMenuBar:
			HideMenuBar ();
			break;
		}
	}

	public void ChangeMenuPanelTo(string key){
		ClearMenuPanels ();
		switch (key) {
		case "Tameru":
			Tameru.SetActive (true);
			break;
		case "Hiromeru":
			SceneManager.LoadScene ("Hiromeru");
			break;
		case "Koukan":
			Koukan.SetActive (true);
			break;
		case "MyPage":
			SceneManager.LoadScene ("MyPage");
			break;
		}
	}

	void ClearMenuPanels(){
		Tameru.SetActive (false);
		Hiromeru.SetActive (false);
		Koukan.SetActive (false);
		MyPage.SetActive (false);
	}
}
