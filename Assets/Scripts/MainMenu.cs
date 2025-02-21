using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("Play");
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
