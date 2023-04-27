using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameTaco.CodeSchool.TappyPlane
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private  GameObject _gameOverScreen;
        
        private int _playerScore;
        
        private void Awake()
        {
            Instance = this;
        }
        
        public void AddScore(int scoreToAdd)
        {
            _playerScore = _playerScore + scoreToAdd;
            _scoreText.text = _playerScore.ToString();
        }
        
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
 
        public void GameOver()
        {
            _gameOverScreen.SetActive(true);
        }
        
    }
}