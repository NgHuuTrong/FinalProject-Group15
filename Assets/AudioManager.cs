using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource[] music;
    public AudioSource[] sfx;
    public int levelMusicToPlay;
    public AudioMixerGroup musicMixer, sfxMixer;

    // private int currentTrack;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayMusic(levelMusicToPlay);
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.M)) {
        //     currentTrack++;
        //     PlayMusic(currentTrack);
        // }
    }

    public void PlayMusic(int musicIndex) {
        foreach (AudioSource source in music)
        {
            source.Stop();
        }
        music[musicIndex].Play();
    }

    public void PlaySFX(int sfxIndex) {
        sfx[sfxIndex].Play();
    }

    public void SetMusicLevel() {
        musicMixer.audioMixer.SetFloat("MusicVol", UIManager.instance.musicVolSlider.value);
    }

    public void SetSFXLevel() {
        musicMixer.audioMixer.SetFloat("MusicVol", UIManager.instance.sfxVolSlider.value);
    }
}
