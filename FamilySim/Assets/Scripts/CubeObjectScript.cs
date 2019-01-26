using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObjectScript : MonoBehaviour
{
    Rigidbody cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("Backspace");
            cube.transform.position = Vector3.zero;
            cube.velocity = Vector3.zero;

        }
    }
}
