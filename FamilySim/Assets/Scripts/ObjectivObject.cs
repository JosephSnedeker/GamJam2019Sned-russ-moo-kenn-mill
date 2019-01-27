using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectivObject : MonoBehaviour
{
    [SerializeField]
    int objectiveCount;    
    [SerializeField]
    string nextScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.objCount == objectiveCount)
        {
            SceneManager.LoadScene(nextScene);
            GameManager.Instance.objCount = 0;
        }
    }
}
