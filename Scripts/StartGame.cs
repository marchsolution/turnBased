using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public GameObject loading;
	public GameObject button;

	public void StartThisShit(){
		Application.LoadLevel("whiteroom");
		loading.SetActive(true);
		button.SetActive(false);
	}


}
