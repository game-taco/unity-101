using UnityEngine;

namespace GameTaco.CodeSchool.ObjectTransform
{
    public class SimpleMovement : MonoBehaviour
    {
        //[SerializeField] private float _speed = 3; // unit/sec
        
        void Update()
        {
            //Get Input
            //float horizontal = Input.GetAxisRaw("Horizontal");
            //float vertical = Input.GetAxisRaw("Vertical");
            
            //Movement direction
            //Vector2 dir  = new Vector2(horizontal, vertical);
            //dir.Normalize();

            //Apply movement
            //transform.position += (Vector3) dir * _speed * Time.deltaTime;
        }
    }
}