using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        if (ballRigidBody != null)
        {
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            ballRigidBody.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);

        }
        else
        {
            Debug.LogWarning("No Rigidbody found on the triggered object.");
        }
    }
}
