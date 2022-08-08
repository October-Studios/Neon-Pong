using UnityEngine;
using System.Collections;

public class PongMenu : MonoBehaviour {
	public GUISkin skin;
	
	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (new Rect(Screen.width/2-300,10,700,100), "Neon Pong");
		if (GUI.Button (new Rect (Screen.width/2-95, 200, 200, 90), "Play"))				
		{
			Application.LoadLevel("Neon Pong");
		}
	}
}