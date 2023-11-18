using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.1f;
        human.transform.position = new Vector3(value, 3, 12);

    }

    public void MoveRight()
    {
        value = value + 0.1f;
        human.transform.position = new Vector3(value, 3, 12);

    }

    public void RotateLeft() 
    {
        human.transform.Rotate(0f, 20f, 0f);

    }
    
    public void RotateRIght()
    {
        human.transform.Rotate(0f, -20f, 0f);

    }

    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChange;
    }

    public void Shrink()
    {
        human.transform.localScale = human.transform.localScale - sizeChange;
    }

    public void Reset()
    {
        human.transform.position = new Vector3(0, 3, 12);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 3, 0));
        human.transform.localScale = new Vector3(2, 2, 2);

    }
}
