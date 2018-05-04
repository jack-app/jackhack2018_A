using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNodes : MonoBehaviour {

	public PostData PD;
	public GameObject preNode;

	void Start(){
		StartCoroutine (MakeCoroutine ());
	}

	public void Make(){
		for (int i = 0; i < PD.pTitle.Count; i++) {
			GameObject obj = Instantiate (preNode, transform);
			obj.GetComponent<KokokuNode> ().pID = i;
		}
	}

	IEnumerator MakeCoroutine(){
		yield return new WaitForSeconds (1);
		Make ();
	}
}
