using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crush_shit_sound : MonoBehaviour {
    public AudioClip soundExplosion;
    AudioSource myAudio;

    private bool check = true;


	void Start () {
		myAudio = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }
	
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn" && check == true)
        {
            check = false;
            PlaySound();
            StartCoroutine(OverWhelming());
        }
    }

    IEnumerator OverWhelming()
    {
        yield return new WaitForSeconds(1.5f);
        check = true;
    }
}
