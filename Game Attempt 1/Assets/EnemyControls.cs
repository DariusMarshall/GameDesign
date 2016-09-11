using UnityEngine;
using System.Collections;

public class EnemyControls : MonoBehaviour {

    public float speed = 1f;
    [Range(-10, 10)]
    public float startX;
    [Range(-10, 10)]
    public float startY;
    // Use this for initialization
    void Start () {
        Rigidbody ballRB = GetComponent<Rigidbody>();
        ballRB.velocity = new Vector3(startX, startY, 0) * speed;
    }

	// Update is called once per frame
	void Update () {

	}
}
