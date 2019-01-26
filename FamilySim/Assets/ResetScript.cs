using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch) > 0.5f)
        {
            Debug.Log("Ltrigger pressed");
        }
    }
}
