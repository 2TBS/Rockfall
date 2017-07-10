using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGen : MonoBehaviour {

	public Object[] cavePrefabs;
	public List<GameObject> spawnedCaves;
	public GameObject rock;

	bool spawned;

	public int SPAWN_DISTANCE = 15;
	// Use this for initialization
	void Start () {
		cavePrefabs = Resources.LoadAll("Caves/", typeof(GameObject));
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject cave in spawnedCaves) {
			if( Mathf.Abs(rock.transform.position.y - cave.transform.position.y) >= SPAWN_DISTANCE) {
				
				spawnedCaves.Remove(cave);
				Destroy(cave);
			}
				
		}

		if((int)rock.transform.position.y % 5 == 0) {
			if(!spawned)
				spawnedCaves.Add(Instantiate((GameObject)cavePrefabs[Random.Range(0, cavePrefabs.Length-1)], rock.transform.position + Vector3.down*SPAWN_DISTANCE, Quaternion.Euler(-90,0,0)));
			Debug.Log("Create cave");
			spawned = true;
		} else spawned = false;
	}
}
