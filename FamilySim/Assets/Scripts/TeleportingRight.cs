using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingRight : MonoBehaviour
{
    public Transform Player;
    public float tpHeight = 0f;
    private RaycastHit hit;
    private LineRenderer laserLine;
    private bool isLaser = false;
    // Start is called before the first frame update
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        laserLine.material = new Material(Shader.Find("Sprites/Default"));
        OVRInput.Update();
        if (OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y < 0.81f && laserLine.enabled)
        {
            if (hit.collider.tag == "Teleportable")
            {

                //Limit distyance here. with if statement
                Debug.Log("Player teleported");
                Player.transform.position = new Vector3(hit.point.x, tpHeight, hit.point.z);
                laserLine.enabled = false;

            }
            else
            {

                Debug.Log("Player tried to prop surf");

            }
        }

        if (OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y > 0.8f)
        {

            isLaser = true;
            laserLine.enabled = true;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                laserLine.SetPositions(new Vector3[] { transform.position, hit.point });
                if (hit.collider.tag == "Teleportable")
                {
                    laserLine.startColor = new Color(0, 255, 0);
                    laserLine.endColor = new Color(0, 70, 0);
                }
                else
                { 
                    laserLine.startColor = new Color(255, 0, 0);
                    laserLine.endColor = new Color(70, 0, 0);
                }
            } else
            {
                laserLine.enabled = false;
            }
            
        }
        else
        {
            laserLine.enabled = false;
            isLaser = false;
        }
    }
}
