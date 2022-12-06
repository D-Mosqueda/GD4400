using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaylistTest : MonoBehaviour
{
    public AudioClip[] Music;
    private AudioSource audioSource;

    private float musicVolume = 1f;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip()
    {
        return Music[Random.Range(0, Music.Length)];
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();

        }
        audioSource.volume = musicVolume;
    }
    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
