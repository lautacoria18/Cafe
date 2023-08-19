using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectGrabable : MonoBehaviour
{
    public Vector3 initialPosition;
    public Quaternion initialRotation;

    public void Awake()
    {
        initialRotation = Quaternion.identity;
        initialPosition = transform.position;
    }

    public void RestartPosition()
    {

        transform.rotation = initialRotation;
        transform.position = initialPosition;
    }


}
