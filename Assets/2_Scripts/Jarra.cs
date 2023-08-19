using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jarra : ObjectGrabable
{
    public GameObject newFilter, oldAttach, coffeeDummy;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "FilterTriggerCollider")
        {
            if (Moka.instance.coffeeIn)
            {
                Moka.instance.jarraIn = true;
                newFilter.SetActive(true);
                oldAttach.SetActive(false);
                coffeeDummy.SetActive(false);
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
            else {
                Debug.Log("Falta el cafe polvo");
            
            }
        }
    }
}
