using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectivObject : MonoBehaviour
{

    private int kids;
    [SerializeField]
    private string nextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        kids = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.objCount == kids)
        {
            SceneManager.LoadScene(nextScene);
            GameManager.Instance.objCount = 0;
        }

    }
}
