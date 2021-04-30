using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D body;

    void LateUpdate()
    {
        if (body == null) return;
        transform.position = new Vector3(body.position.x, body.position.y, transform.position.z);
    }
}
