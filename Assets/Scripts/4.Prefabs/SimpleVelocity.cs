using UnityEngine;

namespace GameTaco.CodeSchool.Prefabs
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