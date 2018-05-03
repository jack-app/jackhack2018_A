using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = -1;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            if(Physics.Raycast(ray, 100000))
            {
                SceneManager.LoadScene("Main");

            }
        }
		
	}
}
