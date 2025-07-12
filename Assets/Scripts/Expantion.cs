using UnityEngine;

public class Expantion : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScaleValue;

    private Vector3 _endExpansion; 
    private Vector3 _startExpansion;                        
    private bool _isExpanding = true;                         

    private void Start()
    {
        _startExpansion = transform.localScale;
        _endExpansion = new Vector3(_maxScaleValue, _maxScaleValue, _maxScaleValue);
    }

    private void Update()
    {
        if (_isExpanding)
            Expand();                                        
        else
            Shrink();                                       
    }

    private void Expand()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _endExpansion, Time.deltaTime * _speed);

        if (Vector3.Distance(transform.localScale, _endExpansion) < 0.01f)
        {
            _isExpanding = false;
        }
    }

    private void Shrink()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _startExpansion, Time.deltaTime * _speed);

        if (Vector3.Distance(transform.localScale, _startExpansion) < 0.01f)
        {
            _isExpanding = true;                               
        }
    }
}
