using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introController : MonoBehaviour
{
    AudioSource audio;
    public AudioClip btnclick;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pindahGame(){
        soundClick();
        SceneManager.LoadScene("TataSurya");
    }

    public void keluarGame(){
        soundClick();
        Application.Quit();
    }


    public void soundClick(){
        audio.clip = btnclick;
        audio.Play();
        audio.loop = false;
    }
}
