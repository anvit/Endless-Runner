using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnTime = 2f;
	public float spawnMin = 2f;
	public float spawnMax = 3f;
	public float init_spawnTime = 2f;

	// Use this for initialization
	void Start () {
		Invoke("Spawn",init_spawnTime);
	}

	void Spawn()
	{
		if( Random.Range(0,2) == 0 )
		{
			Instantiate(obj[Random.Range(0,obj.Length)],new Vector3(transform.position.x,2.75f,10f),Quaternion.identity);
		}
		else
		{
			Instantiate(obj[Random.Range(0,obj.Length)],new Vector3(transform.position.x,0.875f,10f),Quaternion.identity);
		}
		Invoke("Spawn",Random.Range(spawnMin,spawnMax));
	}

}
