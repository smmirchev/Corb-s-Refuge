using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManage : MonoBehaviour
{
    public static AudioClip walkSound, runSound, zombieSound, attackSound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        walkSound = Resources.Load<AudioClip>("walkSound");
        runSound = Resources.Load<AudioClip>("runSound");
        zombieSound = Resources.Load<AudioClip>("zombieSound");
        attackSound = Resources.Load<AudioClip>("attackSound");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playSound(string clip)
    {
        switch(clip)
        {
            case "walkSound":
                audioSource.PlayOneShot(walkSound);
                break;
            case "runSound":
                audioSource.PlayOneShot(runSound);
                break;
            case "zombieSound":
                audioSource.PlayOneShot(zombieSound);
                break;
            case "attackSound":
                audioSource.PlayOneShot(attackSound);
                break;
        }
    }
}
