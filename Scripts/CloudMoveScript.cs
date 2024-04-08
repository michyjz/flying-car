using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -20;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = Random.Range(3, 7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("cloud deleted");
            Destroy(gameObject);
        }
    }
}
