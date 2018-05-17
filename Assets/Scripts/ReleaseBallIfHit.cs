using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseBallIfHit : MonoBehaviour
{
    GameObject releaser;
    private void Start()
    {
        releaser = GameObject.FindWithTag("Door1");
    }
    private void OnCollisionEnter(Collision collision)
    {
        releaser.GetComponent<Rigidbody>().isKinematic = false;
    }
}
