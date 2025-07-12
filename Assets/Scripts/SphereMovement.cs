using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    private bool _isMovingForward = true;

    private void Update()
    {
        if (_isMovingForward)
            MoveToEnd();
        else
            MoveToStart();
    }

    private void MoveToEnd()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, Time.deltaTime * _speed);

        if (transform.position == _endPoint.position)
        {
            _isMovingForward = false;
        }
    }

    private void MoveToStart()
    {
        transform.position = Vector3.MoveTowards(transform.position, _startPoint.position, Time.deltaTime * _speed);

        if (transform.position == _startPoint.position)
        {
            _isMovingForward = true;
        }
    }
}
