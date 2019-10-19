﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioFile[] audioFiles;
    AudioSource audioSource;
    public static AudioManager i;

    public void Init () {
        audioSource = GetComponent<AudioSource> ();
        i = this;
    }

    public void PlayOneShot (int index) {
        AudioClip clip;
        try {
            clip = audioFiles[index].audioClip;
        } catch (System.Exception) {

            throw;
        }

        if (!clip) { return; }
        audioSource.PlayOneShot (clip);
    }

}

[System.Serializable]
public class AudioFile {
    public AudioClip audioClip;
    public string soundName;
}