using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    private float speed = 5;
    // Update is called once per frame
    void LateUpdate()
    {
        var move = new Vector2( Input.GetAxis( "Horizontal" ), Input.GetAxis( "Vertical" ) );
        var look = new Vector2( Input.GetAxis( "Mouse X" ), -Input.GetAxis( "Mouse Y" ) );
        var scroll = Input.GetAxis( "Mouse ScrollWheel" );


        speed += scroll*10;
        
        transform.position += transform.TransformDirection(new Vector3(move.x,0,move.y))*speed*Time.deltaTime;
        
        transform.Rotate( new Vector3( 0,look.x,0 ) );
        transform.Rotate( new Vector3( look.y,0,0 ) );
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
    }
}
