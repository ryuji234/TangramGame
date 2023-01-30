using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static partial class GF
{
    public static void QuitThisGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }           // QuitThisGame

    public static void RyuGF(this GameObject obj_)
    {
        Debug.Log("이것은 내가 만든 함수이다.");
    }

    public static void LoadScence(string sceneName_)
    {
        SceneManager.LoadScene(sceneName_);
    }

}
    

