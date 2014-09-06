using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	int score= 0;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("Score");
		GUIText overtext = GameObject.Find("over_text").guiText;
		GUIText scoretext = GameObject.Find("score_text").guiText;
		overtext.text = "Game Over";
		scoretext.text = "Score: " + score;
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect((Screen.width/2)-30, ((Screen.height/2)+50),100,30),"Retry?"))
		{
			Application.LoadLevel(0);
		}
		if(GUI.Button(new Rect((Screen.width/2)-30, ((Screen.height/2)+100),100,30),"Exit"))
		{
			Application.Quit();
		}
	}
}
