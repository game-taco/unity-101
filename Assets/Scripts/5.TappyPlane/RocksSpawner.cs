using UnityEngine;

namespace GameTaco.CodeSchool.TappyPlane
{
    public class RocksSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _rock;
        [SerializeField] private float _spawnRate = 2;
        [SerializeField] private float _heightOffset = 10;

        private float _timer = 0;

        void Start()
        {
            Spawn();
        }

        void Update()
        {
            if (_timer < _spawnRate)
            {
                _timer += Time.deltaTime;
            }
            else
            {
                _timer = 0;
                Spawn();
            }

        }

        void Spawn()
        {
            Instantiate(_rock, transform.position + Vector3.up * Random.Range(-_heightOffset, _heightOffset),
                transform.rotation);
        }
    }
}