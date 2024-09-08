using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource[] music;
    public AudioSource[] sfx;
    public int levelMusicToPlay;

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
}
