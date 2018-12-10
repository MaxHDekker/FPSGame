using UnityEngine;
using System.Collections;

public class WalnkingSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Update()
    {
            if (Input.GetKeyDown("a"))
            {
                audioSource.clip = audioClip;
                audioSource.Play();
            }
            if (Input.GetKeyUp("a"))
            {
                audioSource.clip = audioClip;
                audioSource.Stop();
            }
        if (Input.GetKeyDown("d"))
            {
                audioSource.clip = audioClip;
                audioSource.Play();
            }
        if (Input.GetKeyUp("d"))
        {
            audioSource.clip = audioClip;
            audioSource.Stop();
        }
        if (Input.GetKeyDown("w"))
            {
                audioSource.clip = audioClip;
                audioSource.Play();
            }
        if (Input.GetKeyUp("w"))
        {
            audioSource.clip = audioClip;
            audioSource.Stop();
        }
        if (Input.GetKeyDown("s"))
            {
                audioSource.clip = audioClip;
                audioSource.Play();
            }
        if (Input.GetKeyUp("s"))
        {
            audioSource.clip = audioClip;
            audioSource.Stop();
        }


    }
    }

