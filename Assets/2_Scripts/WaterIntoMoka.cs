using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterIntoMoka : MonoBehaviour
{
    Vector3 start = Vector3.zero;
    Vector3 end = new Vector3(0.04f, 0.1834807f, 0.02f);

    Vector3 finalPosition = new Vector3(-0.11185202f, 1.83669996f, 0.906799972f);

    Vector3 endDispenserScale = new Vector3(0.39009583f, 0.137634724f, 0.398489445f);
    Vector3 endDispenserPosition = new Vector3(0.209399998f, -0.82852f, 0.0192000009f);

    public bool startDisp;
    public float lerpSpeed;
    void Update()
    {
        if (startDisp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, endDispenserScale, lerpSpeed * Time.deltaTime);
            transform.localPosition = Vector3.Lerp(transform.localPosition, endDispenserPosition, lerpSpeed * Time.deltaTime);
        }
    }
}
