using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatSpeed = 3f;      // Ne kadar hızlı yukarı-aşağı gitsin
    public float floatAmplitude = 0.5f; // Ne kadar mesafe yukarı-aşağı gitsin

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // Başlangıç konumunu kaydet
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
