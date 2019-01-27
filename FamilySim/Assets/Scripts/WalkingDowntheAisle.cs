using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingDowntheAisle : MonoBehaviour
{
    private TeleportingLeft teleportLeft;
    private TeleportingRight teleportRight;
    private Rotate rotate;
    private float timeLeft = 5;
    private bool waited = false;
    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {

        teleportRight = transform.GetChild(1).GetComponent<TeleportingRight>();
        teleportLeft = transform.GetChild(2).GetComponent<TeleportingLeft>();
        rotate = transform.GetComponent<Rotate>();
        //teleportRight = transform.Find("RightHand").GetComponent<TeleportingRight>();

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && !waited)
        {

            waited = true;

        }

        if (transform.position.x > -33 && waited && !done)
        {

            transform.position = new Vector3(transform.position.x - 0.04f, transform.position.y, transform.position.z);
           
        }
        if (transform.position.x <= -33 && waited)
        {

            done = true;
            teleportLeft.enabled = true;
            teleportRight.enabled = true;
            rotate.enabled = true;

        }

    }
}
