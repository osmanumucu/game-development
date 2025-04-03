using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    private float upAndDOwnSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Plane movement up and down
        float VerticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.up * upAndDOwnSpeed * VerticalInput);

    }
}
