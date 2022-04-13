using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{

    public AudioMixer myAM;
    public void SetVolume(float vol)
    {
        myAM.SetFloat("Volume", vol);
    }
}
