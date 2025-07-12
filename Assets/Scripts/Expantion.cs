using UnityEngine;

public class Expantion : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScaleValue;

    private Vector3 _endExpansion;

    private void Start()
    {
        _endExpansion = new Vector3(_maxScaleValue, _maxScaleValue, _maxScaleValue);
    }

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _endExpansion, Time.deltaTime * _speed);
    }
}
