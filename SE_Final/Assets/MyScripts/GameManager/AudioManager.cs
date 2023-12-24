// I'm following the lecturer's instructions as seen suring Lesson 6. I'm creating the audio part of the game manager.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager{
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip[] soundEffects; // This is an array of all the sound effects in the game.
    private AudioSource audioPlay; // This is the audio source component that will play the sound effects.

    public AudioSource BackgroundMusic; // This is the audio source component that will play the background music.

    private void Awake()
   {
    if (Instance == null) // If there is no instance of the audio manager, then create one.
    {
        Instance = this; // This is the instance of the audio manager.
        DontDestroyOnLoad(gameObject); // This will make sure that the audio manager is not destroyed when we load a new scene.
    }
    else
    {
        Destroy(gameObject); // If there is an instance of the audio manager, then destroy it.
        return;
   }
    audioPlay = GetComponent<AudioSource>(); // This is the audio source component that will play the sound effects.
   }

public void PlaySoundEffect(string clipName)
{
    AudioClip clip = FindClipByName(clipName);
    if(clip != null)
    {
        audioPlay.PlayOneShot(clip);
    }
    else
    {
        Debug.LogWarning("Sound effect not found: " + clipName);
    }
}

private AudioClip FindClipByName(string clipName)
{
    foreach(AudioClip clip in soundEffects)
    {
        if(clip.name.Equals(clipName))
        {
            return clip;
        }
    }
    return null;
}
}
}