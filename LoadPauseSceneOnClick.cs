using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadPauseSceneOnClick : MonoBehaviour {

    public string loadScene;
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(loadScene, LoadSceneMode.Additive);
    }
}
