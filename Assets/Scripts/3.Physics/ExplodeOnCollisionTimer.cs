using System;
using UnityEngine;

namespace GameTaco.CodeSchool.Physics
{
    public class ExplodeOnCollisionTimer : MonoBehaviour
    {
        [SerializeField] private float _radius = 2;
        [SerializeField] private float _force = 200;
        [SerializeField] private float _timeToExplode = 2;

        private float _timer = 0;

        private void Update()
        {
            if (_timer <= 0)
                return;

            _timer -= Time.deltaTime;
            if (_timer <= 0)
                Explode();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            //Start the timer on Collision
            if (_timer > 0)
                return;

            _timer = _timeToExplode;
        }

        private void Explode()
        {
            //Get all the colliders in the zone
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, _radius);
            foreach (Collider2D c in colliders)
            {
                //Apply force if it has a Rigidbody
                if (c.TryGetComponent(out Rigidbody2D rb))
                {
                    Vector2 dir = (c.transform.position - transform.position).normalized;
                    rb.AddForce(dir * _force, ForceMode2D.Impulse);
                }
            }

            gameObject.SetActive(false);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, _radius);
        }
    }
}