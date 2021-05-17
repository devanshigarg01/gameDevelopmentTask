using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   
    public Transform Player;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
       transform.position= Player.position + offset; 
    }
}
