using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] GameObject resumeBtn;
    [SerializeField] GameObject mainMenuBtn;
    [SerializeField] GameObject quitBnt;

    // Start is called before the first frame update
    void Start()
    {
        resumeBtn.SetActive(false);
        mainMenuBtn.SetActive(false);
        quitBnt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!resumeBtn.activeSelf)
            {
                Time.timeScale = 0f;
                resumeBtn.SetActive(true);
                mainMenuBtn.SetActive(true);
                quitBnt.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
                Resume();
            
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        resumeBtn.SetActive(false);
        mainMenuBtn.SetActive(false);
        quitBnt.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
