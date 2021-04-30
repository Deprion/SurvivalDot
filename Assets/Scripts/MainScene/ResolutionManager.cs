using UnityEngine;
using UnityEngine.UI;
using System;

public class ResolutionManager : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.GetInt("FirstLaunchEnded") == 1) return;

        bool fullScreen = Convert.ToBoolean(PlayerPrefs.HasKey("FullScreen")) ?
            Convert.ToBoolean(PlayerPrefs.GetInt("FullScreen")) : true;

        int width = PlayerPrefs.HasKey("ResolutionWidth") ? PlayerPrefs.GetInt("ResolutionWidth") :
            Screen.resolutions[Screen.resolutions.Length - 1].width;

        int height = PlayerPrefs.HasKey("ResolutionHeight") ? PlayerPrefs.GetInt("ResolutionHeight") :
            Screen.resolutions[Screen.resolutions.Length - 1].height;

        Screen.SetResolution(width, height, fullScreen, Screen.currentResolution.refreshRate);

        PlayerPrefs.SetInt("FirstLaunchEnded", 1);
    }
    public void ChangeResolution(Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                Screen.SetResolution(1280, 720, Screen.fullScreen, Screen.currentResolution.refreshRate);
                SaveRes(1280, 720);
                break;
            case 1:
                Screen.SetResolution(1600, 900, Screen.fullScreen, Screen.currentResolution.refreshRate);
                SaveRes(1600, 900);
                break;
            case 2:
                Screen.SetResolution(1920, 1080, Screen.fullScreen, Screen.currentResolution.refreshRate);
                SaveRes(1920, 1080);
                break;
            case 3:
                Screen.SetResolution(2560, 1440, Screen.fullScreen, Screen.currentResolution.refreshRate);
                SaveRes(2560, 1440);
                break;
            case 4:
                Screen.SetResolution(3840, 2160, Screen.fullScreen, Screen.currentResolution.refreshRate);
                SaveRes(3840, 2160);
                break;
            case 5:
                Screen.SetResolution(Screen.resolutions[Screen.resolutions.Length - 1].width,
                    Screen.resolutions[Screen.resolutions.Length - 1].height,
                    true, Screen.currentResolution.refreshRate);
                SaveRes(Screen.resolutions[Screen.resolutions.Length - 1].width,
                    Screen.resolutions[Screen.resolutions.Length - 1].height);
                break;
        }
    }

    public void ChangeFullScreen(Toggle value)
    {
        Screen.fullScreen = value.isOn;
        PlayerPrefs.SetInt("FullScreen", Convert.ToInt32(value.isOn));
    }
    private void SaveRes(int width, int height)
    {
        PlayerPrefs.SetInt("ResolutionWidth", width);
        PlayerPrefs.SetInt("ResolutionHeight", height);
    }
}
