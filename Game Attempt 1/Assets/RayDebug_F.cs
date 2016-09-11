using UnityEngine;
using System.Collections;

public class RayDebug_F : MonoBehaviour
{

    public float range = 100f;

    private Camera cam;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lineOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 lineOrigin = Input.mousePosition;
        Debug.DrawRay(lineOrigin, cam.transform.forward * range, Color.green);
    }
}
