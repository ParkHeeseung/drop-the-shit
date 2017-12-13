using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crush_shit_sound : MonoBehaviour {
    public AudioClip soundExplosion;
    AudioSource myAudio;
    private bool check = true;
  /*  public static crush_shit_sound instance;

    void Awake()
    {
        if (crush_shit_sound.instance == null)
        {
            crush_shit_sound.instance = this;
        }
    }*/

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
        if (other.gameObject.tag == "Respawn" && check)
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
