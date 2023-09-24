using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameProgressHandler gameProgressHandler;

    private Camera mainCamera => Camera.main;
    private Ray HitRay => mainCamera.ScreenPointToRay(Input.mousePosition);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleBallClick();
        }
    }

    private void HandleBallClick()
    {
        if (!Physics.Raycast(HitRay, out var hit)) return;
        var ball = hit.collider.GetComponent<Ball>();
        if (ball == null) return;
        ball.Pop();
        gameProgressHandler.RemoveBall(ball);
        gameProgressHandler.CheckWinCondition();
    }
}