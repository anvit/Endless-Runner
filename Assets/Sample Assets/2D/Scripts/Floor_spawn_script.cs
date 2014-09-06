using UnityEngine;
using System.Collections;

public class Floor_spawn_script : MonoBehaviour {

	public GameObject[] obj;

	private float oldPosition;
	private float currentPosition;
	private float ctr = 0;

	// Use this for initialization
	void Start () {
		oldPosition = transform.position.x;
		AddRoom (ctr*19.19f);
		ctr += 1;
		AddRoom (ctr*19.19f);
		ctr += 1;
		AddRoom (ctr*19.19f);
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition = transform.position.x;
		if((currentPosition-oldPosition)>=9.595f)
		{
			AddRoom(ctr*19.19f);
			oldPosition = transform.position.x;
			ctr += 1;
		}
	}

	void AddRoom(float roomCenter)
	{
		GameObject room = (GameObject)Instantiate(obj[Random.Range(0, obj.Length)]);
		room.transform.position = new Vector3(roomCenter, 0f, 10f);
	}

}
