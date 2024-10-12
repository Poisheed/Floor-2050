using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float slowingTime = 2f;

    private Vector2 movement;
    public bool isMoving;
   
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D per muovere a sinistra/destra
        movement.y = Input.GetAxisRaw("Vertical"); // W/S per muovere su/giù

        if (movement.x != 0 || movement.y != 0)
        {
            isMoving = true;
            transform.position += new Vector3(movement.x, movement.y, 0) * moveSpeed * Time.deltaTime;
        }
        else
        {
            movement = Vector2.Lerp(movement, Vector2.zero, slowingTime * Time.deltaTime);
            isMoving = false;
        }
    }
}