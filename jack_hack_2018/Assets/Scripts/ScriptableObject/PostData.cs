using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptableObject/PostData", fileName = "PostData")]
public class PostData : ScriptableObject {
	public string[] pFileName;
	public string[] pSumnail;
	public string[] pTitle;
	public string[] pComment;
	public string[] pType;
	public float[] pPlayTime;
}
