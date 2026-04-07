using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;

    public BasicEventSO onPlayerPosChanged;
    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 dir = input.normalized;
        Vector3 velocity = dir * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.position += moveAmount;

        onPlayerPosChanged.raise(this, transform.position);
    }
}
