using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;  //シーン管理できるようにするやつ
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
    public void ToInGameScene()
    {
        SceneManager.LoadScene("InGame");
    }
    public void ToResultScene()
    {
        SceneManager.LoadScene("Result");
    }
    public void ToGameEnd()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }
}
