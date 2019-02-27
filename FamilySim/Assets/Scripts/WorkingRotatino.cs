using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingRotatino : MonoBehaviour
{
    [SerializeField]
    Transform obj;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x) > 0.4)
        {
            Debug.Log("ASD");
            obj.position = transform.position;
            transform.SetParent(obj);
            obj.Rotate(Vector3.up, OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x * 180 * Time.deltaTime);
            

        }
        else
        {
            transform.SetParent(null);
        }
    }
}
