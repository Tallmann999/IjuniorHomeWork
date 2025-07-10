using UnityEngine;


public class TerritoryBypass : MonoBehaviour
{
    // Четвертый – это куб, который движется в том направлении, в которое он смотрит,
    // поворачивается по оси Y и растет в размере одновременно.
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
            //transform.rotation = transform.LookAt(); здесь сделать поворот в сторону новой точки и расширение
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
