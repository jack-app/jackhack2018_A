using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptableObject/PostData", fileName = "PostData")]
public class PostData : ScriptableObject {
	public string[] DataPath;
}
