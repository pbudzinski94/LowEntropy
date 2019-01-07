using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class WinLevel : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        if(WinCondition())
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if(SceneManager.sceneCount < nextSceneIndex)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }

    public abstract bool WinCondition();
}
