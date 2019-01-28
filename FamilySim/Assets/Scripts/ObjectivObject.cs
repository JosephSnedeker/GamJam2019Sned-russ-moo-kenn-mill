using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectivObject : MonoBehaviour
{

    private int kids;
    [SerializeField]
    private int nextScene;
    
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
            int buildIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (buildIndex >= 5)
            {

                buildIndex = 0;

            }
            SceneManager.LoadScene(buildIndex);
            GameManager.Instance.objCount = 0;
        }

    }
}
