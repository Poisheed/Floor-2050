using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Transform target;

    private bool screenIsMoving;

    void Update()
    {
        if (screenIsMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                screenIsMoving = false;
            }
        }

    }
    public void ScreenMovementButton()
    {
        screenIsMoving = true;
    }

}
