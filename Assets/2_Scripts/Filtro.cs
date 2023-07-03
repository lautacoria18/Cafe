using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filtro : MonoBehaviour
{

    public GameObject newFilter;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MokaTriggerCollider")
        {
            if (Moka.instance.waterIn)
            {
                Moka.instance.filterIn = true;
                newFilter.SetActive(true);
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
            else {

                Debug.Log("Falta el agua");
            
            }
        }
    }
}
