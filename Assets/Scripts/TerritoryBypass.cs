using UnityEngine;


public class TerritoryBypass : MonoBehaviour
{
    // ��������� � ��� ���, ������� �������� � ��� �����������, � ������� �� �������,
    // �������������� �� ��� Y � ������ � ������� ������������.
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speedMovement;

    private int currentIndex; 
    private Vector3 nextTarget; 

    void Start()
    {
        transform.position = _points[0].position;
        SetNextTarget();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextTarget, _speedMovement * Time.deltaTime);

        if (transform.position == nextTarget)
        {
            SetNextTarget();
            //transform.rotation = transform.LookAt(); ����� ������� ������� � ������� ����� ����� � ����������
        }
    }

    private void SetNextTarget()
    {
        do
        {
            currentIndex = UnityEngine.Random.Range(0, _points.Length);
        }
        while (_points[currentIndex].position == nextTarget);

        nextTarget = _points[currentIndex].position;
    }

}
