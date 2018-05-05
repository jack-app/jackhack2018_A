using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
using System;

public class DataImpoter : MonoBehaviour {

	public PostData PD;

	public MakeNodes MN;

	// Use this for initialization
	void Start () {
		//Import ();
	}

	public void Import(){
		ClearPD ();

		NCMBQuery<NCMBObject> postQuery = new NCMBQuery<NCMBObject> ("PostData");

		postQuery.FindAsync ((List<NCMBObject> objList ,NCMBException e) => {
			if (e != null) {
				//検索失敗時の処理
			} else {
				// 取得したレコードをHighScoreクラスとして保存
				foreach (NCMBObject obj in objList) {
					ArrayList pdata = (ArrayList)obj["DataArray"];

					PD.pFileName.Add(pdata[0].ToString());
					PD.pSumnail.Add(pdata[1].ToString());
					PD.pTitle.Add(pdata[2].ToString());
					PD.pComment.Add(pdata[3].ToString());
					PD.pType.Add(pdata[4].ToString());
					PD.pPlayTime.Add(pdata[5].ToString());
					PD.pIntro.Add(pdata[6].ToString());
					PD.pPlayCount.Add(pdata[7].ToString());
				}
			}
		});
	}

	void ClearPD(){
		PD.pFileName.Clear ();
		PD.pSumnail.Clear ();
		PD.pTitle.Clear ();
		PD.pComment.Clear ();
		PD.pType.Clear ();
		PD.pPlayTime.Clear ();
		PD.pIntro.Clear ();
		PD.pPlayCount.Clear ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
