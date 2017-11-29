using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crush_shit_sound : MonoBehaviour {
    public AudioClip soundExplosion;
    AudioSource myAudio;

    public static crush_shit_sound instance;

    void Awake()
    {
        if (crush_shit_sound.instance == null)
        {
            crush_shit_sound.instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }
	
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Respawn")
        {
            PlaySound();
        }


    }


}
