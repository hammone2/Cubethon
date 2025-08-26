using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public float forwardForce = 2000f;
    public float strafeForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(strafeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-strafeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // end game if the player falls off
        if (rb.position.y <= -3)
        {
            GameManager.instance.EndGame();
        }
    }
}
