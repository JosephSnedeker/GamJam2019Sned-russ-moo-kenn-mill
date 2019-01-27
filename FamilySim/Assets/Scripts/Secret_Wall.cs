using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret_Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) && OVRInput.Get(OVRInput.Button.Three))
        {
            Destroy(gameObject);
        }
    }
}
