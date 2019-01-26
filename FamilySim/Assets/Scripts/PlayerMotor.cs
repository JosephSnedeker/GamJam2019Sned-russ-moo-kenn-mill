using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    
    [SerializeField]
    private Camera cam;
    private Vector3 velocity = Vector3.zero;
    private Rigidbody rb;
    private Vector3 rotation = Vector3.zero;
    private Vector3 cameraRotation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameManager.Instance.ballCams.Add(cam);
       
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.player = rb;
        GameManager.Instance.look = (cam.transform.rotation.eulerAngles);
        
    }
    public void Move (Vector3 velocity2)
    {
        velocity = velocity2;
    }
    public void Rotate (Vector3 Rotation2)
    {
        rotation = Rotation2;
    }
    public void RotateCamera (Vector3 cameraRotation2)
    {
        cameraRotation = cameraRotation2;
    }
    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }
    void PerformMovement()
    {
        if (velocity != Vector3.zero )
        {
            rb.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
        }
    }
    void PerformRotation()
    {
        rb.MoveRotation(transform.rotation * Quaternion.Euler(rotation));
        if (cam)
        {
            cam.transform.Rotate(cameraRotation);
        }
    }
  

}
