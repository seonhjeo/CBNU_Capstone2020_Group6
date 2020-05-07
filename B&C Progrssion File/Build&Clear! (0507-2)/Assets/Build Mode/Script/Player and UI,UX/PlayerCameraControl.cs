﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControl : MonoBehaviour
{
    public World world;

    public Transform playerBody;

    float xRotation = 0f;

    private void Update()
    {
        if (!world.inUI)
        {
            float mouseX = Input.GetAxis("Mouse X") * world.settings.mouseSensitivity * 100 * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * world.settings.mouseSensitivity * 100 * Time.deltaTime;

            xRotation -= mouseY;

            transform.localRotation = Quaternion.Euler(Mathf.Clamp(xRotation, -90, 90), 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
