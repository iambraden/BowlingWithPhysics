using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private Transform launchIndicator;

    private Rigidbody ballRB;
    private bool isBallLaunched;
    
    
    void Start()
    {
        // Grabbing a reference to RigidBody
        ballRB = GetComponent<Rigidbody>();


        // Add a listener to the OnSpacePressed event
        // When the space key is pressed the
        // LaunchBall method will be called.
        inputManager.OnSpacePressed.AddListener(LaunchBall);

        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;

        ballRB.isKinematic = true;
    }

    private void LaunchBall()
    {
        // now your if check can be framed like a sentence
        // if the ball is launched, return and do nothing.
        if (isBallLaunched) return;
        isBallLaunched = true;
        transform.parent = null;
        ballRB.isKinematic = false;
        ballRB.AddForce(launchIndicator.forward * force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);
        //ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    
    void Update()
    {
        
    }
}
