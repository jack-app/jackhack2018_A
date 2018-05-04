using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kakera;
using UnityEngine.UI;

public class HiromeruController: MonoBehaviour {

	public string[] data = new string[8];

	public InputField ifTitle;
	public InputField ifComment;
	public InputField ifType;
	public InputField ifPlayTime;
	public InputField ifIntro;
	public InputField ifPlayCount;

	[SerializeField] private Unimgpicker imagePicker;

	public void SetSumnail(){
		// Unimgpicker returns the image file path.
		imagePicker.Completed += (string path) =>
		{
			if(data[1] == ""){
			string id = Time.time.ToString();
			data[1] = id;
			StartCoroutine(SaveData(path,data[1]));
			}
		};
		OnPressShowPicker ();
	}

	public void SetFile(){
		// Unimgpicker returns the image file path.
		imagePicker.Completed += (string path) =>
		{
			if(data[0] == ""){
			string id = Time.time.ToString();
			data[0] = id;
			StartCoroutine(SaveData(path,data[0]));
			}
		};
		OnPressShowPicker ();
	}

	public void SetDatas(){
		SetTitle ();
		SetComment ();
		SetPlayTime ();
		SetType ();
		SetIntro ();
		SetPlayCount ();

		PostData (data);
	}
		
	public void SetTitle(){
		data [2] = ifTitle.text;
	}

	public void SetComment(){
		data [3] = ifComment.text;
	}

	public void SetPlayTime(){
		data [5] = ifPlayTime.text;
	}

	public void SetType(){
		data [4] = ifType.text;
	}

	public void SetIntro(){
		data [6] = ifIntro.text;
	}

	public void SetPlayCount(){
		data [7] = ifPlayCount.text;
	}

	public void OnPressShowPicker()
	{
		imagePicker.Show( "Select Image", "unimgpicker", 1024 );
	}



	private IEnumerator SaveData( string path, string fname)
	{
		Debug.Log (path);
		var url = "file://" + path;
		var www = new WWW (url);
		yield return www;

		SaveFileData.SaveFromByte (www.bytes, fname);
	}

	void PostData(string[] d){
		SaveFileData.SendPostData (d);
	}

	void PostData(string FileName, string SumnailName, string Title, string Comment, string pType, string PlayTime, string Intro, string PlayCount){
		string[] postdata = new string[]{FileName, SumnailName, Comment, pType, PlayTime.ToString(), Intro, PlayCount.ToString()};
		SaveFileData.SendPostData (postdata);
	}
}
