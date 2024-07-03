using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR.OpenXR.Input;

public class GameManager : MonoBehaviour
{
    [SerializeField] VideoPlayer player;
    [SerializeField] Slider slider;

    void Update()
    {
        ControlVolume();
    }
    public void PlayVideo()
    {
        player?.Play();
    }

    public void PauseVideo()
    {
        player?.Pause();
    }

    public void ControlVolume()
    {
        if (player == null) return;
        player.SetDirectAudioVolume(0,slider.value);
    }

}
