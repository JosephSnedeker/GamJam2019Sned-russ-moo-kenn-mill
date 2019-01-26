﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.AddComponent<Rigidbody>();
            GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }
    }
}
