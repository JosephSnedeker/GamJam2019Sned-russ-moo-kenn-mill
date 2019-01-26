using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public int camNumber { get; set; }
    static GameManager instance;

    public Rigidbody player { get; set; }

    public Vector3 look { get; set; }

   

    public List<Camera> ballCams { get; set; } = new List<Camera>();
    
     

    public int ballCount = 0;


    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }

    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.X))
        {
            ballCams[camNumber].enabled = false;
            camNumber += 1;
            if (camNumber == ballCams.Count)
            {
                camNumber = 0;
            }
            ballCams[camNumber].enabled = true;
        }
    }
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}  

