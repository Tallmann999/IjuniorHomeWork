using UnityEngine;

public class TerritoryBypass : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speedMovement;

    private int _currentIndex;
    private Vector3 _nextTarget;

    void Start()
    {
        transform.position = _points[0].position;
        SetNextTarget();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _nextTarget, _speedMovement * Time.deltaTime);

        if (transform.position == _nextTarget)
        {
            SetNextTarget();
            transform.LookAt(_nextTarget);
        }
    }

    private void SetNextTarget()
    {
        do
        {
            _currentIndex = UnityEngine.Random.Range(0, _points.Length);
        }
        while (_points[_currentIndex].position == _nextTarget);

        _nextTarget = _points[_currentIndex].position;
    }
}
