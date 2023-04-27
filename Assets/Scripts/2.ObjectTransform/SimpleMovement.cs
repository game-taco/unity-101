using UnityEngine;

namespace GameTaco.CodeSchool.ObjectTransform
{
    public class SimpleMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 3;
        
        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            
            Vector2 dir  = new Vector2(horizontal, vertical);
            dir.Normalize();

            transform.position += (Vector3) dir * _speed * Time.deltaTime;
        }
    }
}