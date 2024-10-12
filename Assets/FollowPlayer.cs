using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public float followSpeed = 2f;
    public float yOffset = 1f;
    public Transform player;

    public bool bounds;
    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3 (player.position.x, player.position.y + yOffset, -10f); // Camera follows the player position
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed*Time.deltaTime);

        if (bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x), Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y), 
            Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
        }
    }

}
