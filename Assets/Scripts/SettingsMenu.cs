using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] AudioMixer audioMixer;

    public void  BackBtn()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void SetMasterVolume(Slider slider)
    {
        audioMixer.SetFloat("Master", slider.value);
    }
    
    public void SetMusicVolume(Slider slider)
    {
        audioMixer.SetFloat("Music", slider.value);
    }
    
    public void SetSFXVolume(Slider slider)
    {
        audioMixer.SetFloat("SFX", slider.value);
    }
}
