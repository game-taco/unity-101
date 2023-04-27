using UnityEngine;

namespace GameTaco.CodeSchool.TappyPlane
{
    public class ScoreDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                GameManager.Instance.AddScore(1);
            }
        }
    }
}