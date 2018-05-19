using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetKinematicToFalseSlider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
