using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _mover;
    private int _score;

    private void Start()
    {
        _score = 0;
        _mover = GetComponent<PlayerMover>();
    }

    public void ResetGame()
    {
        _score = 0;
        _mover.ResetPlayer();
        Time.timeScale = 1;
    }

    public void Die()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0;
    }
}
