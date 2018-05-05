using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptableObject/PostData", fileName = "PostData")]
public class PostData : ScriptableObject {
	public List<string> pFileName;
	public List<string> pSumnail;
	public List<string> pTitle;
	public List<string> pComment;
	public List<string> pType;
	public List<string> pPlayTime;
	public List<string> pIntro;
	public List<string> pPlayCount;

	public List<int> MaxNagesen;
}
