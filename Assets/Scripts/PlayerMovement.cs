using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForse = 2000f;
    public float sideWaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        //Dissable gravity in rigidbody component
        //rb.useGravity = false;\
        //Moving once for cardinate
        //rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Continuesly moving , triggered once per frame 
        //rb.AddForce(0, 0, 200);


        // Time.deltaTime example.
        //
        // Wait two seconds and display waited time.
        // This is typically just beyond 2 seconds.
        // Allow the speed of the time to be increased or decreased.
        // It can range between 0.5 and 2.0. These changes only
        // happen when the timer restarts.
        rb.AddForce(0, 0, forwardForse * Time.deltaTime); // Add a forward force

        if ( Input.GetKey("d") ) // turn using key d to the right
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // turn using key a to the left 
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        { 
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
