using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update

    public static SoundController instance;
    private AudioSource gameAudio;

    public void Awake(){
        this.gameAudio = this.gameObject.GetComponent<AudioSource>();
        instance = this;
    }


    // Update is called once per frame

    public void PlayClip(string clipName){
        Debug.Log(gameAudio);
        AudioClip clip = (AudioClip)Resources.Load("Sounds/" + clipName);
        Debug.Log(clip);
        gameAudio.PlayOneShot(clip);
    }

}
