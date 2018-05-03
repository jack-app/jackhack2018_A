using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using System;

public class MainController : MonoBehaviour {

	enum mState{
		Idle,ShowingMenuBar
	}

	private mState state = mState.Idle;

	// Use this for initialization
	void Start () {
		Vector3 mPos = Camera.main.ScreenToViewportPoint (Input.mousePosition ());
		switch (state) {
		case mState.Idle:
			break;
		case mState.ShowingMenuBar:
			if (Input.GetMouseButtonDown (0) && mPos.x > 0.4) {
				HideMenuBar ();
			}
			break;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
		}
	}

	public void ShowMenuBar(){
		
	}

	void HideMenuBar(){
		
	}
}
