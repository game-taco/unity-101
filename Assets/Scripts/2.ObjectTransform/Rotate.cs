using UnityEngine;

namespace GameTaco.CodeSchool.ObjectTransform
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField] private float _angle = 90; //degrees/sec

        void Update()
        {
            //Invert if we press Space
            if (Input.GetKeyDown(KeyCode.Space))
                _angle *= -1;

            //Rotate the amount each frame
            transform.Rotate(Vector3.forward, _angle * Time.deltaTime);
        }
    }
}