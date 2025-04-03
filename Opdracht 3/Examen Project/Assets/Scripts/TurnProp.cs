using UnityEngine;

public class TurnProp : MonoBehaviour
{
    private float rotationSpeed = 1200f;
    // Update is called once per frame
    void Update()
    {
        // Rotation for plane's prop
        transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
    }
}
