using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y < 0.4)
        {

            transform.Rotate(new Vector3(0, OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x * 3, 0));

        }
        if(OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y < 0.4)
        {

            transform.Rotate(new Vector3(0, OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x * 3, 0));

        }
    }
}
