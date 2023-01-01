using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BasicMovement : MonoBehaviour
{
    public float speed;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement= Input.GetAxis("Horizontal");
        controller.Move(Vector3.forward * movement * Time.deltaTime);
    }
}
