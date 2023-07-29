using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{

    public FallingWater water;

    private void Awake()
    {
        water= FindObjectOfType<FallingWater>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "DispenserTrigger") {

            water.StartToVERT(true);
        
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "DispenserTrigger")
        {

            water.StartToVERT(false);

        }

    }

}
