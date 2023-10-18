using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Cinemachine;

public class PlayerController : MonoBehaviour
{
    public GameObject car; // Reference to the car GameObject
    public CinemachineVirtualCameraBase camera1; // Reference to the first Cinemachine camera
    public CinemachineVirtualCameraBase camera2; // Reference to the second Cinemachine camera

    private bool isInCar = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (isInCar)
                ExitCar();
            else
                GetInCar();
        }
        if (Input.GetKeyDown(KeyCode.E)) // Switch cameras when pressing 'E'
        {
            camera2.gameObject.SetActive(!camera2.gameObject.activeSelf); // Toggle camera 2
        }
        // Your character control code here (e.g., move using Input.GetKeyDown(KeyCode.W))
    }

    void GetInCar()
    {
        isInCar = true;
        gameObject.SetActive(false); // Disable the player
        car.SetActive(true); // Enable the car

        // You may also need to transfer any input handling to the car controller script
    }

    void ExitCar()
    {
        isInCar = false;
        car.SetActive(false); // Disable the car
        gameObject.SetActive(true); // Enable the player

        // Transfer control back to character controller
    }
}