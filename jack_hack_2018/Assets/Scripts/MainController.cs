using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using System;

public class MainController : MonoBehaviour {

	enum mState{
		Idle,ShowingMenuBar
	}

	public GameObject MenuBar;

	private mState state = mState.Idle;

	// Use this for initialization
	void Start () {
		
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
		MenuBar.GetComponent<Animator> ().SetBool ("ShowMenuBar",true);
		state = mState.ShowingMenuBar;
	}

	void HideMenuBar(){
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
}
