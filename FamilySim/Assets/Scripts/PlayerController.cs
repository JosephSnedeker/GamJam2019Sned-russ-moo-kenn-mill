  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 1;

    private PlayerMotor motor;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }
    private void Update()
    {
        //calculate movement velocity as a 3d vector
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");
        if (GameManager.Instance.ballCams[0].enabled)
        {
            Vector3 moveHorizontal = transform.right * xMove;
            Vector3 moveVertical = transform.forward * zMove;
            //final movement vector
            Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;
            motor.Move(velocity);
            //calculate rotation as a 3d vector
            float yRot = Input.GetAxisRaw("Mouse X");
            Vector3 rotation = new Vector3(0, yRot, 0) * lookSensitivity;
            //apply rotation
            motor.Rotate(rotation);
            //calculate camera rotation as a 3d vector
            float xRot = Input.GetAxisRaw("Mouse Y");
            Vector3 cameraRotation = new Vector3(xRot, 0, 0) * lookSensitivity;
            //apply rotation
            motor.RotateCamera(-cameraRotation);
        }

        


    }
   
}
