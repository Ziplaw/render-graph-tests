using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        var move = new Vector2( Input.GetAxis( "Horizontal" ), Input.GetAxis( "Vertical" ) );
        var look = new Vector2( Input.GetAxis( "Mouse X" ), 0 );
        
        

        transform.position += transform.TransformDirection(new Vector3(move.x,0,move.y)*5*Time.deltaTime);
        transform.Rotate( new Vector3( 0,look.x,0 ) );
    }
}
