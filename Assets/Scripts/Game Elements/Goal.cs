using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Scene transition with animation
        SceneTransitioner transition = FindObjectOfType<SceneTransitioner>();

        if (transition != null)
        {
            transition.StartLevelLoad(nextLevel);
        }
        // default to simple scene load
        else
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
