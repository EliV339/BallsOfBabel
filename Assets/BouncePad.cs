using UnityEngine;

public class BouncePad : MonoBehaviour
{
    public float bounceForce = 15f;
    
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Reset vertical velocity for consistent bounce height, then apply bounce
            Vector3 vel = rb.linearVelocity;
            vel.y = bounceForce;
            rb.linearVelocity = vel;
        }
    }
}