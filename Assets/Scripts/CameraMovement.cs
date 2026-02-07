using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

    public static bool canMove;

    private void Awake()
    {
        canMove = true;
    }

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
        if (!canMove) return;

        if (inputActions.FindAction("Move").WasPressedThisFrame()) // W
        {
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
        else if (inputActions.FindAction("Rotate left").WasPressedThisFrame()) // A
        {
            transform.Rotate(0, -90f, 0);
        }
        else if (inputActions.FindAction("Rotate right").WasPressedThisFrame()) // D
        {
            transform.Rotate(0, 90f, 0);
        }
    }
    void changePosition(Position newPos)
    {
        currentPosition = newPos.gameObject;
        transform.position = newPos.transform.position;
        indexesInPosList = (newPos.X, newPos.Z);
    }
}