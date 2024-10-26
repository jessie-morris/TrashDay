﻿using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{   
    //FindObjectOfType<AudioManager>().Play("SoundName");
    public Sound[] sounds;
    public static AudioManager instance;

    // Awake is called before start
    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        } 
        else 
        {
            Destroy(gameObject);
            return;
        }

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        //Play("Theme", .1f);
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

         if(s == null)
         {
            Debug.LogWarning("Sound " + name + " not found!");
            return;
        }

        if (!s.source.isPlaying){
            //Debug.Log("playing sound: " + name);
            s.source.Play();
        }        
    }

    public void Play(string name, float clipVolume)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

         if(s == null)
         {
            Debug.LogWarning("Sound " + name + " not found!");
            return;
        }

        if (!s.source.isPlaying){
            //Debug.Log("playing sound: " + name);
            s.source.volume = clipVolume;
            s.source.Play();
        }        
    }

    public void Stop(string name)
    {
         Sound s = Array.Find(sounds, sound => sound.name == name);

         if(s == null)
         {
            Debug.LogWarning("Sound " + name + " not found!");
            return;
        }

        if (s.source.isPlaying){
            s.source.Stop();
        }        
    }

    public void PlayOneShot(string name)
    {
         Sound s = Array.Find(sounds, sound => sound.name == name);

         if(s == null)
         {
            Debug.LogWarning("Sound " + name + " not found!");
            return;
        }
        
        //Debug.Log("oneshot playing sound: " + name);
        s.source.PlayOneShot(s.clip, s.volume);
    }
}
