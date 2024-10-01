using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 3.0f;

    public GameObject maze;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        maze.transform.rotation = maze.transform.rotation * Quaternion.Euler(translation, rotation, 0);
    }
}
