using Mirror;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : NetworkBehaviour
{
    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMovement>().body = body;
    }
    void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        body.MovePosition(body.position + new Vector2
            (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.fixedDeltaTime);
    }
}
