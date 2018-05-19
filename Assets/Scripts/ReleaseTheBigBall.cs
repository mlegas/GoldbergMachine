using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseTheBigBall : MonoBehaviour {

    private GameObject bigBall;
    private void Start()
    {
        bigBall = GameObject.FindWithTag("BigBall");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            bigBall.GetComponent<Rigidbody>().isKinematic = false;
            bigBall.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
