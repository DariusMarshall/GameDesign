using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float fireRate = 0.25f;
    private float nextFire;
    private Camera cam;
    private float Damage = 25f;
    public float mousex;
    public float mousey;
	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        //mousex = Input.GetAxisRaw("Mouse X");
        //mousey = Input.GetAxisRaw("Mouse Y");
        // print(mousex);
        print(Input.mousePosition);
    
	if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Vector3 rayOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(rayOrigin, cam.transform.forward * 100, out hit))
            {
                Health health = hit.collider.GetComponent<Health>();
                if (health != null)
                {
                    health.Damage(Damage);
                }
            }

        }
	}
}
