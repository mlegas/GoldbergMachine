using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTheCannon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CannonShooter")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            var rigidBody = this.gameObject.GetComponent<Rigidbody>();
            var cannonForce = this.gameObject.transform.up * 5000f * Time.deltaTime;
            var position = this.gameObject.transform.position;

            rigidBody.AddForceAtPosition(cannonForce, position, ForceMode.VelocityChange);
        }
    }

}