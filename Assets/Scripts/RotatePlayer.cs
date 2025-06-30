using UnityEngine;

public class PlayerJumpRotate : MonoBehaviour
{
    public float jumpForce = 10f;
    public float rotationSpeed = 180f; // derajat per detik
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private bool isRotating = false;
    private float rotationAmount = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Lompat saat tekan space dan di tanah
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
            isRotating = true;
            rotationAmount = 0f;
        }

        // Deteksi kalau jatuh ke tanah lagi (bisa ganti pakai raycast/ground check)
        if (rb.linearVelocity.y == 0 && !isGrounded)
        {
            isGrounded = true;
        }

        // Rotasi saat lompat
        if (isRotating)
        {
            float rotateStep = rotationSpeed * Time.deltaTime;
            transform.Rotate(0f, 0f, -rotateStep);
            rotationAmount += rotateStep;

            if (rotationAmount >= 360f)
            {
                isRotating = false;
                rotationAmount = 0f;
                // Pastikan rotasi bulat
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
    }
}
