using UnityEngine;

namespace GameTaco.CodeSchool.ObjectTransform
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField] private float _angle = 90;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _angle *= -1;

            transform.Rotate(Vector3.forward, _angle * Time.deltaTime);
        }
    }
}