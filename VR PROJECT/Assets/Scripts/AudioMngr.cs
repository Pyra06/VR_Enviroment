using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMngr : MonoBehaviour
{
    public AudioClip onClick1, onClick2;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click1()
    {
        audioSource.PlayOneShot(onClick1);
    }

    public void Click2()
    {
        audioSource.PlayOneShot(onClick2);
    }
}
