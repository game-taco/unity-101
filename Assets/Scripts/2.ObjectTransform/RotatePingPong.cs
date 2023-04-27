using UnityEngine;

namespace GameTaco.CodeSchool.ObjectTransform
{
    public class RotatePingPong : MonoBehaviour
    {
        [SerializeField] private float _angle; // max angle
        [SerializeField] private float _rotSpeed; // degrees/sec

        void Update()
        {
            // float delta = Mathf.PingPong(Time.time * _rotSpeed, _angle);
            // transform.rotation = Quaternion.Euler(0, 0, delta - _angle/2f);
        }
    }
}