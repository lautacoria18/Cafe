using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuchara_Behaviour : ObjectGrabable
{
    public GameObject cafe;
    public GameObject cafeBowl1, cafeBowl2, cafeBowl3, cafeBowl4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CafeEnBowl")
        {

            cafe.SetActive(true);

        }
        if (other.gameObject.tag == "FilterTriggerCollider")
        {
            if (cafe.activeSelf) {

                cafe.SetActive(false);
                if (!cafeBowl1.activeSelf)
                {
                    cafeBowl1.SetActive(true);

                }
                else if (!cafeBowl2.activeSelf)
                {

                    cafeBowl2.SetActive(true);

                }
                else if (!cafeBowl3.activeSelf)
                {

                    cafeBowl3.SetActive(true);

                }
                else if (!cafeBowl4.activeSelf)
                {

                    cafeBowl4.SetActive(true);
                    Moka.instance.coffeeIn = true;

                }
            }
            Debug.Log("tocapallenar");
            cafe.SetActive(false);
            //
            //cafe.SetActive(true);

        }
    }
}
