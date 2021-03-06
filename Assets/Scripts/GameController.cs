using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private GameOverScreen _gameOverScreen;

    private bool _isGameOver;

    public bool IsGameOver => _isGameOver;

    private void OnEnable()
    {
        _startScreen.StartButtonClick += OnStartButtonClick;
        _gameOverScreen.RestartButtonClick += OnRestartButtonClick;
        _player.GameOver += OnGameOver;
    }

    private void OnDisable()
    {
        _startScreen.StartButtonClick -= OnStartButtonClick;
        _gameOverScreen.RestartButtonClick -= OnRestartButtonClick;
        _player.GameOver -= OnGameOver;
    }

    private void Start()
    {
        Time.timeScale = 0;
        _isGameOver = true;
        _startScreen.OpenScreen();
    }

    private void OnStartButtonClick()
    {
        _startScreen.CloseScreen();
        StartGame();
    }

    private void OnRestartButtonClick()
    {
        _gameOverScreen.CloseScreen();
        _pipeGenerator.ResetPool();
        StartGame();
    }

    private void OnGameOver()
    {
        Time.timeScale = 0;
        _isGameOver = true;
        _gameOverScreen.OpenScreen();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _isGameOver = false;
        _player.ResetGame();
    }
}
