using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResumeSceneOnClick : MonoBehaviour {

    public string unloadScene;
    public void resume()
    {
        SceneManager.UnloadScene(unloadScene);
    }
}
