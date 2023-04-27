using UnityEngine;

namespace GameTaco.CodeSchool.Physics
{
    public class SimpleVelocity : MonoBehaviour
    {
        [SerializeField] private Vector2 _velocity;
        void Start()
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = _velocity;
        }

    }
}