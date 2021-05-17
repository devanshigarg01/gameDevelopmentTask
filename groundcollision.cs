using UnityEngine;

public class groundcollision : MonoBehaviour
{
    public PlayerMovement movement;
   void OnCollisionEnter (Collision collisionInfo)
   {
     if ( collisionInfo.collider.tag == "Ground" )
     {
       movement.enabled = false;
     }
     

   }
}