using UnityEngine;
using System.Collections;

public class MasterGUI : MonoBehaviour {
	public Texture texture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI (){
		//GUI.Box (new Rect(Screen.width * .2f, Screen.height, Screen.width * .6f, Screen.height), "label");
		GUI.Box(new Rect(0, 0, Screen.width, Screen.height), texture);
		Debug.Log ("debug");
	}
}
