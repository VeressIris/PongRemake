using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioClip hitSound;
    private AudioClip goalSound;
    private AudioSource audioSrc;

    void Start()
    {
        hitSound = Resources.Load<AudioClip>("Hit");
        goalSound = Resources.Load<AudioClip>("Goal");

        audioSrc = GetComponent<AudioSource>();
    }

    public void PlaySound(string clip)
    {
        switch(clip)
        {
            case "hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "goal":
                audioSrc.PlayOneShot(goalSound);
                break;
        }
    }
}
