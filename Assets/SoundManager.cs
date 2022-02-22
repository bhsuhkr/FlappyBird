using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip startButton, scoreUp, die;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        startButton = Resources.Load<AudioClip>("startButton");
        scoreUp = Resources.Load<AudioClip>("scoreUp");
        die = Resources.Load<AudioClip>("die");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "startButton":
                audioSrc.PlayOneShot(startButton);
                break;
            case "scoreUp":
                audioSrc.PlayOneShot(scoreUp);
                break;
            case "die":
                audioSrc.PlayOneShot(die);
                break;
        }
    }
}
