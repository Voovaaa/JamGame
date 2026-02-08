using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JamGame
{
public class CameraMovement : MonoBehaviour
{
    public GameObject currentPosition;
    public (int, int) indexesInPosList;
    public List<List<GameObject>> positions;
    public GameObject posX1Z1;
    public GameObject posX2Z1;
    public GameObject posX1Z2;
    public GameObject posX2Z2;

    public InputActionAsset inputActions;

    public bool updatePosCommand;

    public Options options;

    private void Start()
    {
        positions = new List<List<GameObject>>();
        positions.Add(new List<GameObject> { null, null, null, null });
        positions.Add(new List<GameObject> { null, posX1Z1, posX1Z2, null });
        positions.Add(new List<GameObject> { null, posX2Z1, posX2Z2, null });
        positions.Add(new List<GameObject> { null, null, null, null });
        currentPosition = posX1Z1;
        transform.position = currentPosition.transform.position;
        indexesInPosList = (currentPosition.GetComponent<Position>().X, currentPosition.GetComponent<Position>().Z);
    }

    private void Update()
    {
        if (inputActions.FindAction("Menu").WasPressedThisFrame()) // W
        {
            this.options.Activate();
        }
        //Debug.Log(transform.rotation.eulerAngles);
        if (inputActions.FindAction("Move").WasPressedThisFrame()) // W
        {   
            /*
            Debug.Log(positions[0][1]);
            Debug.Log(indexesInPosList.Item1);
            Debug.Log(indexesInPosList.Item2);
            Debug.Log(transform.rotation.eulerAngles);
            Debug.Log(transform.rotation.eulerAngles.y);
            Debug.Log(transform.rotation.eulerAngles.y == 0.0f);
            Debug.Log(transform.rotation.eulerAngles.y == 90.0f);
            Debug.Log(transform.rotation.eulerAngles.y == 180.0f);
            Debug.Log(transform.rotation.eulerAngles.y == 270.0f);
            Debug.Log(positions[indexesInPosList.Item1 + 1][indexesInPosList.Item2] != null);
            */
            indexesInPosList = (currentPosition.GetComponent<Position>().X, currentPosition.GetComponent<Position>().Z);
            if (transform.rotation.eulerAngles.y == 0.0f &&
                positions[indexesInPosList.Item1 - 1][indexesInPosList.Item2] != null) //UP
            {
                changePosition(positions[indexesInPosList.Item1 - 1][indexesInPosList.Item2].GetComponent<Position>());
            }
            else if (transform.rotation.eulerAngles.y == 90.0f &&
                positions[indexesInPosList.Item1][indexesInPosList.Item2 + 1] != null) //RIGHT
            {
                changePosition(positions[indexesInPosList.Item1][indexesInPosList.Item2 + 1].GetComponent<Position>());
            }
            else if (transform.rotation.eulerAngles.y == 180.0f &&
                    positions[indexesInPosList.Item1 + 1][indexesInPosList.Item2] != null) //DOWN
            {
                changePosition(positions[indexesInPosList.Item1 + 1][indexesInPosList.Item2].GetComponent<Position>());
            }
            else if (transform.rotation.eulerAngles.y == 270.0f &&
                positions[indexesInPosList.Item1][indexesInPosList.Item2 - 1] != null) //LEFT
            {
                changePosition(positions[indexesInPosList.Item1][indexesInPosList.Item2 - 1].GetComponent<Position>());
            }
        }
        else if (inputActions.FindAction("Rotate left").WasPressedThisFrame())
        {
            transform.Rotate(0, -90f, 0);
        }
        else if (inputActions.FindAction("Rotate right").WasPressedThisFrame())
        {
            transform.Rotate(0, 90f, 0);
        }
        if (updatePosCommand)
        {
            updatePosCommand = false;
            changePosition(currentPosition.GetComponent<Position>());
        }
    }
    void changePosition(Position newPos)
    {
        currentPosition = newPos.gameObject;
        transform.position = newPos.transform.position;
        indexesInPosList = (newPos.X, newPos.Z);
    }
}
}
