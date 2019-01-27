using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingDowntheAisle : MonoBehaviour
{
    private float timeLeft = 5;
    private bool waited = false;
    public TeleportingLeft teleLeft;
    public TeleportingRight teleRight;
    // Start is called before the first frame update
    void Start()
    {
        teleRight = GetComponent<TeleportingRight>();
        teleLeft = GetComponent<TeleportingLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 && !waited)
        {

            waited = true;

        }

        if (waited)
        {

            if(transform.position.x > -31)
            {

                transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
                teleLeft.enabled = true;
                teleRight.enabled = true;
            }

        }

    }
}
