using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovementMenu : MonoBehaviour
{
    public Transform _target;
    public float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

}
