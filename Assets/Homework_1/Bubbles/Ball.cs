using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BallType ballType;

    public BallType BallType => ballType;

    public void Pop()
    {
        Destroy(gameObject);
    }
}

public enum BallType
{
    Red,
    Green,
    White
}