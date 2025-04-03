using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    private float cloudSpeed = 10.0f; // The movement speed of cloud
    private float goldSpeed = 7.5f; // The movement speed of gold

    private float skullSpeed = 9.0f; // The movement speed of skull
    private float zDestroy = -20f; // The position when it will be destroyed

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Cloud"))
        {
            CloudMovement();
        } else if (CompareTag("Gold"))
        {
            GoldMovement();
        } else if (CompareTag("Skull"))
        {
            SkullMovement();
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

        void SkullMovement()
    {
        transform.Translate(Vector3.back * skullSpeed * Time.deltaTime); // Making the skull move to the left side

        // Destroy the cloud if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
    
}
