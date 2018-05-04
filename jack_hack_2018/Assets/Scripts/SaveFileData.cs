using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class SaveFileData : MonoBehaviour {

	void Start(){
		//Save ("image", @"/Users/syoui/jack_hack/jack_hack2018/jack_hack_2018/Assets/Data/Resources/grass1.jpg");
	}

	public static void Save(string pType, string spath){
		//string path = spath.Replace("/","¥¥");
		string path = "¥¥Users¥¥syoui¥¥Library¥¥Application Support¥¥DefaultCompany¥¥jack_hack_2018¥¥unimgpicker";
		Debug.Log (path);
		switch (pType) {
		case "image":
			//ファイルを開く
			System.IO.FileStream fs = new System.IO.FileStream(
				path,
				System.IO.FileMode.Open,
				System.IO.FileAccess.Read);
			//ファイルを読み込むバイト型配列を作成する
			byte[] bs = new byte[fs.Length];
			//ファイルの内容をすべて読み込む
			fs.Read(bs, 0, bs.Length);
			//閉じる
			fs.Close();

			//ファイルデータ送信
			NCMBFile file = new NCMBFile ("grass1.jpg", bs);
			file.SaveAsync ((NCMBException error) => {
				if (error != null) {
					Debug.Log("Sippai");
					// 失敗
				} else {
					Debug.Log("Seikou");
					// 成功
				}
			});
			break;
		}
	}

	public static void SaveFromByte(byte[] bs, string name){
		//ファイルデータ送信
		NCMBFile file = new NCMBFile (name, bs);
		file.SaveAsync ((NCMBException error) => {
			if (error != null) {
				Debug.Log("Sippai");
				// 失敗
			} else {
				Debug.Log("Seikou");
				// 成功
			}
		});
	}

	public static void SendPostData(string[] data){

		NCMBObject obj = new NCMBObject ("PostData");
		obj.Add ("DataArray", data);
		obj.SaveAsync ((NCMBException e) => {      
			if (e != null) {
				//エラー処理
			} else {
				//成功時の処理
			}                   
		});
	}
}
