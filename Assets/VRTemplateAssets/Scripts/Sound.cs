using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Button btn;
    public AudioSource audioSource;
    public AudioClip clip;
    public Sprite iconPlay;
    public Sprite iconPause;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAudio() {
        if(audioSource.isPlaying)
        {
            audioSource.Stop();
            btn.image.sprite = iconPlay;
        }
        else
        {
            audioSource.Play();
            btn.image.sprite = iconPause;
        }
    }
}
