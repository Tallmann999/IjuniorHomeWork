using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _endPoint;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, Time.deltaTime * _speed);
    }
}
