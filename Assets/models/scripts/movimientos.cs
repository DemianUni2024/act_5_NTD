using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotar el objeto en el eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
