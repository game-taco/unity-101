using UnityEngine;

namespace GameTaco.CodeSchool.Physics
{
    public class SimpleForce : MonoBehaviour
    {
        [SerializeField] private float _force = 400;
        
        private Rigidbody2D _rb;
        
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _rb.AddForce(transform.up * _force, ForceMode2D.Impulse);
        }

        private void Update()
        {
            if (_rb.velocity.magnitude < 0.3f)
            {
                _rb.velocity = Vector2.zero;
                return;
            }

            Vector2 dir = _rb.velocity.normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(0,0,angle);
        }
    }
}
