using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class InputMAnager : InputManager
{
    public bool Attacking => Input.GetMouseButtonDown(0);

    public Vector3 motion => new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
}
