using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            SceneManager.LoadScene(0);
    }
}
