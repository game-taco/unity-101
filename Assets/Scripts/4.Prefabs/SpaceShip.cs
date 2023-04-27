using UnityEngine;

namespace GameTaco.CodeSchool.Prefabs
{
    public class SpaceShip : MonoBehaviour
    {
        [SerializeField] private float _acceleration = 3f;
        [SerializeField] private float _desacceleration = 1f;
        [SerializeField] private float _maxSpeed = 1.6f;
        [SerializeField] private float _turnSpeed = 45;

        private Rigidbody2D _rb;
        private float _speed = 0;
        private float _rotAngle;
    
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector2 dir  = new Vector2(horizontal, vertical);
            dir.Normalize();

            if (dir.sqrMagnitude > 0)
            {
                _rotAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
                _speed += _acceleration * Time.deltaTime;
            }
            else
            {
                _speed -= _desacceleration * Time.deltaTime;
                _rotAngle = _rb.rotation;
            }
            
            _speed = Mathf.Clamp(_speed, 0, _maxSpeed);
        }
    
        private void FixedUpdate()
        {
            _rb.rotation = Mathf.LerpAngle(_rb.rotation, _rotAngle, _turnSpeed * Mathf.Deg2Rad * Time.fixedDeltaTime);
            _rb.velocity = transform.up * _speed;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("Game Over");
            enabled = false;
        }
    }
    
}
