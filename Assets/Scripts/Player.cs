using UnityEngine;

public class Playerforreal : MonoBehaviour
{

    public Rigidbody rb;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward, ForceMode.Impulse);
        }
    }
}
