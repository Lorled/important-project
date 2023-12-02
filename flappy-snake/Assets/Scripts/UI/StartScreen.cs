using System;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public static Action GameStarted;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            GameStarted?.Invoke();
            Destroy(gameObject);
        }
    }
}
