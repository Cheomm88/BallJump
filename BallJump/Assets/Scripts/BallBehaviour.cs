using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] float jumpForce = 3f;
    [SerializeField] float ultraSpeed = 10.0f;
    Rigidbody ballRigidbody;
    [SerializeField] GameObject trail;
    // Start is called before the first frame update
    void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        trail.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        trail.SetActive(ballRigidbody.velocity.y < -ultraSpeed);   
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (ballRigidbody.velocity.y < -ultraSpeed)
        {
            Destroy(collision.gameObject);
        }
        else
        {
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }
}
