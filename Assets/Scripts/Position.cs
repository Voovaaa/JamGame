using UnityEngine;

public class Position : MonoBehaviour
{
    public int X;
    public int Z;
    public Vector3 position;

    public void Start()
    {
        position = this.transform.position;
    }


    /*
    public Vector3 GetPosition()
    {
        return this.transform.position;
    }

    public Quaternion GetRotation()
    {
        return this.transform.localRotation;
    }
    */

}
