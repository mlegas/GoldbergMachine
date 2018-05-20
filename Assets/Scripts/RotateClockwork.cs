using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClockwork : MonoBehaviour
{
    private	void Update ()
    {
        this.gameObject.transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
