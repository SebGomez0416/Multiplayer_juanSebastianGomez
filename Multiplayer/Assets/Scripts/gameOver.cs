using System;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    private Camera playerCamera;

    private void Awake()
    {
        playerCamera = GetComponentInChildren<Camera>();
    }

    private void OnEnable()
    {
        bullet.OnPlayerKill += GameOver;
    }

    private void OnDisable()
    {
        bullet.OnPlayerKill -= GameOver;
    }


    private void GameOver()
    {
        playerCamera.rect = new Rect(0, 0, 1, 1);
    }
}
    

