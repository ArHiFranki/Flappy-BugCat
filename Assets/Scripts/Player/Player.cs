using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _mover;
    private int _score;

    public event UnityAction GameOver;

    private void Start()
    {
        _score = 0;
        _mover = GetComponent<PlayerMover>();
    }

    public void AddScore()
    {
        _score++;
    }

    public void ResetGame()
    {
        _score = 0;
        _mover.ResetPlayerCondition();
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
