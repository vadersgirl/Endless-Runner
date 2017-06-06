using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMenuScript : MonoBehaviour {
	public GameObject ActiveMenu;
	public GameObject InactiveMenu;

	public void OnClick (){
		InactiveMenu.SetActive (true);
		ActiveMenu.SetActive (false);
	}
}
