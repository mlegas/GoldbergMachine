using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBowlIfHit : MonoBehaviour
{

    public bool hit = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            hit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hit && this.gameObject.transform.rotation.eulerAngles.x < 150)
        {
             this.gameObject.transform.Rotate(new Vector3(60, 0, 0) * Time.deltaTime);
        }
    }
}
