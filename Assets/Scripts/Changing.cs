using UnityEngine;

public class Changing : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private float _speedScale;
    [SerializeField] private float _endExpansionValue;
    [SerializeField] private float rotationSpeedY;

     private Vector3 _endExpansion;

    private void Start()
    {
        _endExpansion = new Vector3(_endExpansionValue, _endExpansionValue, _endExpansionValue);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMovement * Time.deltaTime);
        transform.localScale = Vector3.MoveTowards(transform.localScale, _endExpansion, _speedScale * Time.deltaTime);
        transform.Rotate(new Vector3(0, rotationSpeedY * Time.deltaTime, 0));
    }
}
