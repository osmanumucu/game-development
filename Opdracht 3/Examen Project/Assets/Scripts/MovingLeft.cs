using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    private float speed = 10.0f; // The speed of cloud moving
    private float zDestroy = -20f; // The position when it will be destroyed

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime); // Making the cloud move to the left side

        // Destroy the cloud if the position on z axis is less then zDestroy
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
