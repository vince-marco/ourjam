using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NavigationBotton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Loadscene(string sceneName)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
    public void ApplicationQuit()
    {
        Debug.Log("Application Quit");
        //Only works on built version
        Application.Quit();
    }
}
