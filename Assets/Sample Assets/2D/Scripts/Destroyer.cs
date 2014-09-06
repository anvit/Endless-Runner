using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		GUIText overtext = GameObject.Find("over_text").guiText;
		if(other.tag == "Player")
		{
			overtext.text = "Game Over";
			Debug.Break ();
			return;
		}

		if(other.gameObject.transform.parent)
		{
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy(other.gameObject);
		}
	}

}