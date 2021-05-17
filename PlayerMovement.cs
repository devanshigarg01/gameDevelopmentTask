using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
// Start is called before the first frame update
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysForce = 500f;
    public float additionalforwardforce = 500f;
// Update is called once per frame
    void Update()
    {
 // Force in Z direction
      rb.AddForce(0 , 0, -forwardforce*Time.deltaTime)  ;

// Movement in x direction
      if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
  // Add a force to the right
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
      if (Input.GetKey("a"))
      {
          rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange); // Add force to the left
      }
      if (Input.GetKey("w"))
      {
          rb.AddForce(0,0,-additionalforwardforce*Time.deltaTime, ForceMode.VelocityChange); // Add force to the left
      }
      if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
    }
}
