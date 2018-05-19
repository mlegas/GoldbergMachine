using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTheCannon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CannonShooter")
        {
            var rigidBody = gameObject.GetComponent<Rigidbody>();

            var cannonForce = gameObject.transform.up * 5000f * Time.deltaTime;

            var position = gameObject.transform.position;

            rigidBody.AddForceAtPosition(cannonForce, position, ForceMode.VelocityChange);
        }
    }

}