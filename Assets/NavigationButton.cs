using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationButton : MonoBehaviour
{
    //Function used by buttons to load the next scene
    public void Loadscene(string sceneName)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
