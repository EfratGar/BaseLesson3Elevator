using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class ElevatorScript : MonoBehaviour
{
//great
    int CurrentFloor;
    // Start is called before the first frame update
    void Start()
    {
        CurrentFloor = 0;
        GoUp(3);
        GoDown(2);
    }

    //function that makes the elevator go up
    void GoUp(int howMuchFloors)
    {
        ClosedDoors();

        CurrentFloor += howMuchFloors;
        Debug.Log($"The elevator is going up {howMuchFloors} floors");

        ElevatorAtDestination();

        OpenDoors();  
    }

    //function that makes the elevator go down
    void GoDown(int howMuchFloors)
    {
        ClosedDoors();

        CurrentFloor -= howMuchFloors;
        Debug.Log($"The elevator is going down {howMuchFloors} floors");

        ElevatorAtDestination();

        OpenDoors();
    }

    void OpenDoors()
    {
        Debug.Log("The doors are open");
    }
    void ClosedDoors()
    {
        Debug.Log("The doors are closing");
    }

    void ElevatorAtDestination()
    {
        Debug.Log($"The elevator is at the floor {CurrentFloor}");
    }
    
}

