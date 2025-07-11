using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.RotateAround(transform.position,new Vector3(0,1,0),_speed*Time.deltaTime);
    }
}
