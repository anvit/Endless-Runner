using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	GUIText scoretext;
	float playerscore = 0;
	// Use this for initialization
	void Start () {
		scoretext = GameObject.Find("score_text").guiText;
		scoretext.text = "Score: ";
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt("Score",(int)playerscore);
	}
	// Update is called once per frame
	void Update () {
		playerscore += (Time.deltaTime * 100);
		scoretext = GameObject.Find("score_text").guiText;
		scoretext.text="Score: "+ (int)(playerscore);
	}
}
