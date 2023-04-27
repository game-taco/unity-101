using UnityEngine;
using Random = UnityEngine.Random;

namespace GameTaco.CodeSchool.Prefabs
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _meteorPrefabs;
        [SerializeField] private float _spawnRate = 2;
        [SerializeField] private float _size = 10;

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
            GameObject meteorPrefab = _meteorPrefabs[Random.Range(0, _meteorPrefabs.Length)];
            Vector3 pos = transform.position + Vector3.right * Random.Range(-_size / 2f, _size / 2f);
            GameObject meteor = Instantiate(meteorPrefab, pos, Quaternion.identity);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireCube(transform.position, new Vector3(_size, 1, 1));
        }
    }
}