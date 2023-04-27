using UnityEngine;

namespace GameTaco.CodeSchool.TappyPlane
{
    public class TappyPlane : MonoBehaviour
    {

        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _tapStrength = 3;
        [SerializeField] private float _maxFallSpeed = -3;

        [Space(20)] [SerializeField] private float _maxRotation = 60;
        [SerializeField] private float _minRotation = -60;
        [SerializeField] private float _rotationSpeed = 15;

        private float _targetAngle = 0;
        private bool _isDead;

        void Update()
        {
            if(_isDead)
                return;
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rb.velocity = Vector2.up * _tapStrength;
            }
            else if (_rb.velocity.y < _maxFallSpeed)
            {
                _rb.velocity = Vector2.up * _maxFallSpeed;
            }

            float angle = Map(_rb.velocity.y, _maxFallSpeed, _tapStrength, _minRotation, _maxRotation);
            _targetAngle = Mathf.LerpAngle(_targetAngle, angle, _rotationSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, _targetAngle);
        }

        float Map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }
        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead = true;
            GameManager.Instance.GameOver();
        }
    }
}