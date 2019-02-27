using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementFix : MonoBehaviour
{
    private Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam = transform.GetChild(0).transform;
        transform.position = new Vector3(cam.position.x,cam.position.y,cam.position.z);
        
    }
}
