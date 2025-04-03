using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    // The movement speed of different objects
    private float cloudSpeed = 10.0f;
    private float goldSpeed = 7.5f;
    private float skullSpeed = 9.0f;
    private float rockSpeed = 10.0f;
    private float healSpeed = 10.0f;

    // The position when the objects will be destroyed
    private float zDestroy = -20f; 


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
        } else if (CompareTag("Rock"))
        {
            RockMovement();
        } else if (CompareTag("Heal"))
        {
            HealMovement();
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

        // Destroy the object if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }

    void RockMovement()
    {
        transform.Translate(Vector3.back * rockSpeed * Time.deltaTime); // Making the rock move to the left side

        // Destroy the object if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }

        void HealMovement()
    {
        transform.Translate(Vector3.back * healSpeed * Time.deltaTime); // Making the heal move to the left side

        // Destroy the object if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
    
}
