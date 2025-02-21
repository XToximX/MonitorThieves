using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayBtn()
    {
        Debug.Log("Play");
    }
    
    public void SettingsBtn()
    {
        Debug.Log("Settings");
    }
    
    public void QuitBtn()
    {
        Application.Quit();
    }
}
