using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSelector : MonoBehaviour
{
    public AudioSource backgroundMusic;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchMusic (AudioClip music)
    {
        FadeOut(backgroundMusic, 2.0f);
        backgroundMusic.clip = music;
        FadeIn(backgroundMusic, 4.0f);

    }

    public void SwitchMusicOneShot(AudioClip music)
    {
        FadeOut(backgroundMusic, 2.0f);
        backgroundMusic.clip = music;
        backgroundMusic.PlayOneShot(music);

    }

    public void FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

           
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }

    public void FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.2f;

        audioSource.volume = 0;
        audioSource.Play();

        while (audioSource.volume < 1.0f)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

        }

        audioSource.volume = 1f;
    }
}
