using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    public GameObject CourseUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStartButton()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void GameSettingButton()
    {

    }
    public void OnCourseButton()
    {
        CourseUI.SetActive(true);
    }
    public void OnCouseRuturnButton()
    {
        CourseUI.SetActive(false);
    }

    public void GameExitButton()
    {
        Application.Quit();
    }
}
