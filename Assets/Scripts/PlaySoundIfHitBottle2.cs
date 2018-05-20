using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIfHitBottle2 : MonoBehaviour
{
    private bool hasPlayed = false;
    private bool displayButtons = false;

    public GameObject canvas;

    private AudioSource audio;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bottle" && !hasPlayed)
        {
            audio.Play();
            hasPlayed = true;
        }
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audio.isPlaying && hasPlayed)
        {
            if (!displayButtons)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                displayButtons = true;

                canvas.SetActive(true);
            }
        }
    }
}
