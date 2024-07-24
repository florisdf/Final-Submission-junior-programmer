using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float JumpForce { get; private set; } = 10.0f; // ENCAPSULATION

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    protected void JumpWithForce(float force) // ABSTRACTION
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        Debug.Log($"Jump with force {force}");
    }

    public virtual void Jump()
    {
        JumpWithForce(JumpForce);
    }
}
