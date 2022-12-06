using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource AudioSource;

    private float musicVolume = 1f;

    private void Start()
    {

        AudioSource.Play();
    }

    private void Update()
    {
        AudioSource.volume = musicVolume;

    }


    public void updateVolume( float volume )
    {
        musicVolume = volume;
    }
}
