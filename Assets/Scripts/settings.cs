using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;
public class settings : MonoBehaviour
{

    public AudioMixer myAM;
    Resolution[] resolutions;
    public TMPro.TMP_Dropdown AudioDropdown;
    public TMPro.TMP_Dropdown resolutionDropdown;
  //  [SerializeField] Camera c;
  //  [SerializeField] SceneRenderPipeline sRP;

    [SerializeField] GameObject menuCanvas;
    [SerializeField] GameObject settingsCanvas;

    [SerializeField] AudioClip lazerSFX;

    float gameVol;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i=0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetVolume(float vol)
    {
        myAM.SetFloat("Volume", vol);
        gameVol = vol;
    }

    public float GetVolume()
    {
        return gameVol;
    }

    public void SetResolution(int Index)
    {
        Resolution resolution = resolutions[Index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetAPI(int APIIndex)
    {
        //  
       // 
      //  
     //  
    }

    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void ChangeAudioSettings(int audio)
    {
        if (audio == 0)
        {
            AudioSettings.speakerMode = AudioSpeakerMode.Mono;
        }
        if (audio == 1)
        {
            AudioSettings.speakerMode = AudioSpeakerMode.Stereo;
        }
        if (audio == 2)
        {
            AudioSettings.speakerMode = AudioSpeakerMode.Mode5point1;
        }
        if (audio == 3)
        {
            AudioSettings.speakerMode = AudioSpeakerMode.Prologic;
        }
    }

    public void SetAntiAliasing(int AA)
    {
        if (AA == 0)
        {
            QualitySettings.antiAliasing = 0;
        }
        else if (AA == 1)
        {
            QualitySettings.antiAliasing = 2;
        }

        else if (AA == 2)
        {
            QualitySettings.antiAliasing = 4;
        }
        else if (AA == 8)
        {
            QualitySettings.antiAliasing = 8;
        }

    }

    public void OpenSettings()

    {
        AudioSource.PlayClipAtPoint(lazerSFX, transform.position, 1);
        settingsCanvas.SetActive(true);
        menuCanvas.SetActive(false);
    }
    public void CloseSettings()
    {
        AudioSource.PlayClipAtPoint(lazerSFX, transform.position, 1);
        settingsCanvas.SetActive(false);
        menuCanvas.SetActive(true);

    }

}
