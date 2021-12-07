using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitioner : MonoBehaviour
{

    public Animator Animator;
    public float AnimationTime;

    public void StartLevelLoad(string levelName)
    {
        StartCoroutine(LoadLevel(levelName));
    }

    IEnumerator LoadLevel(string levelName)
    {
        Animator.SetTrigger("Loading");

        yield return new WaitForSeconds(AnimationTime);

        SceneManager.LoadScene(levelName);
    }

}
