using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sentakushi : MonoBehaviour {
    public Dropdown dropdown;
    public string s;
    public void Sentaku_shi()
    {
        switch (dropdown.value)
        {
            case 0:s = "movie";break;
            case 1:s = "image";break;
            case 2:s = "music";break;
            case 3:s = "URL";break;
        }

    }
}
