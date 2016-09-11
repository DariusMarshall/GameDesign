using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public int spawnAmount = 3;
    public Vector2 spawnRange;
	// Use this for initialization
	void Start () {
	for (int i = 0; i < spawnAmount; i++)
        {
            GameObject PU = (GameObject)Instantiate(enemy);
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            PU.transform.Translate(pos);
            PU.transform.Translate(Random.Range(-spawnRange.x, spawnRange.x), Random.Range(-spawnRange.y, spawnRange.y), 0);
            PU.transform.parent = this.transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
