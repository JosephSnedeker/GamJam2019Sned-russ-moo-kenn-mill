using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    
    static GameManager instance;

    public int objCount { get; set; }
    public TeleportingLeft teleLeft { get; set; }
    public TeleportingRight teleRight { get; set; }









    public static GameManager Instance
    { get { return instance ?? ((instance = new GameManager())); } }

    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }
    private void Update()
    {

    }
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }
}  

