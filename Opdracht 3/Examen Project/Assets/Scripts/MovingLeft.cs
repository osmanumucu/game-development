using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    private float cloudSpeed = 10.0f; // The speed of cloud moving
    private float goldSpeed = 7.5f; // The speed of gold moving
    private float zDestroy = -20f; // The position when it will be destroyed

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Cloud"))
        {
            CloudMovement();
        }

        if (CompareTag("Gold"))
        {
            GoldMovement();
        }

    }

    void CloudMovement()
    {
        transform.Translate(Vector3.back * cloudSpeed * Time.deltaTime); // Making the cloud move to the left side

        // Destroy the cloud if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }

    void GoldMovement()
    {
        transform.Translate(Vector3.back * goldSpeed * Time.deltaTime); // Making the cloud move to the left side

        // Destroy the cloud if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
    
}
