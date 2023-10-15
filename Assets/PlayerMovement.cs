using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 2.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed;
        float moveHorizontal = Input.GetAxis("Horizontal") * rotationSpeed;
        Vector3 movement = new Vector3(0f, 0f, moveVertical);
        rb.velocity = transform.TransformDirection(movement);
        transform.Rotate(Vector3.up * moveHorizontal * Time.deltaTime);
    }

    public void ApplySpeedBoost(float speedBoost)
    {
        moveSpeed *= speedBoost;
    }
}
