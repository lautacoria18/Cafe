using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {

        Debug.Log("toca");
        if (other.gameObject.tag == "Moka" || other.gameObject.tag == "Cuchara" || other.gameObject.tag == "ParteArriba" || other.gameObject.tag == "Filtro" || other.gameObject.tag == "Taza") {

            Debug.Log("tocaPISO");

            if (other.gameObject.GetComponent<Moka>())
            {
                other.gameObject.GetComponent<Moka>().RestartPosition();
            }
            if (other.gameObject.GetComponent<Cuchara_Behaviour>())
            {
                other.gameObject.GetComponent<Cuchara_Behaviour>().RestartPosition();
            }
            if (other.gameObject.GetComponent<Jarra>())
            {
                other.gameObject.GetComponent<Jarra>().RestartPosition();

            }
            if (other.gameObject.GetComponent<Filtro>())
            {
                other.gameObject.GetComponent<Filtro>().RestartPosition();
            }
            if (other.gameObject.GetComponent<Taza>())
            {
                other.gameObject.GetComponent<Taza>().RestartPosition();
            }

        }
    }
}
