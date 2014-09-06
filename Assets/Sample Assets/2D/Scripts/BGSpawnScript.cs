using UnityEngine;
using System.Collections;

public class BGSpawnScript : MonoBehaviour {
	public GameObject[] obj;
	public float spawnMin = 2f;
	public float spawnMax = 5f;
	// Use this for initialization
	void Start () {
		BGSpawn();
	}

	void BGSpawn()
	{
		GameObject bg = (GameObject) Instantiate(obj[Random.Range(0,obj.Length)],new Vector3(transform.position.x,3f,10f),Quaternion.identity);
		bg.renderer.sortingOrder =  Random.Range(-3,-1);
		Invoke("BGSpawn",Random.Range(spawnMin,spawnMax));
	}

	// Update is called once per frame
	void Update () {
	
	}
}
