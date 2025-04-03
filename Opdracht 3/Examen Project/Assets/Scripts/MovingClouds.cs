using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatSpeed = 7f;      // How fast the clouds are moving up and down
    public float floatAmplitude = 0.5f; // The range of clouds going up and down

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // Starting position
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
