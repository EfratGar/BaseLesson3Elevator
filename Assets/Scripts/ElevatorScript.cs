using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class ElevatorScript : MonoBehaviour
{
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




//Extra(Optional):
//Create your elevator class. V

//Write methods for the elevator like:
//Void GoUp(int howMuchFloors)
//{
//    ..
//}
//In the start method call your methods with values:
//Start
//{
//GoUp(3);
//GoDown(2);
//...
//}
//Put a Debug.Log in the methods that describes the behaviour.
//You can also use conditionals to decide it a method should execute like so:
//Bool isShabat = true;
//Start
//{ if(isShabat==true){
//DoShabatBehaviour(); //it’s a method that stops in all the floors one by one
//}else
//{
//    GoUp(3);
//}}
//*important note: you can call methods inside methods!