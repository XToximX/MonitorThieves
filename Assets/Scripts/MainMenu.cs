using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Menus")]
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject settingsMenu;

    public void Start()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(1);
    }
    
    public void SettingsBtn()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    
    public void QuitBtn()
    {
        Application.Quit();
    }
}
