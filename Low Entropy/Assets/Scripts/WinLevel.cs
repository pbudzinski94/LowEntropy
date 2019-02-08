using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class WinLevel : MonoBehaviour
{
    private bool isWon = false;
    // Update is called once per frame
    void Update()
    {
        if (WinCondition() && !isWon)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if(SceneManager.sceneCount < nextSceneIndex)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            Debug.Log("U won");
            isWon = true;
        }
    }

    public abstract bool WinCondition();
}
