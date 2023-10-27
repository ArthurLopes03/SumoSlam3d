using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{
    public string Scene;
    
    public void loadScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
