using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAboutOnScript : MonoBehaviour {

    public string loadScene;

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(loadScene, LoadSceneMode.Additive);
    }

}
