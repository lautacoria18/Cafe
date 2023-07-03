using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeParticleCollider : MonoBehaviour
{
    public Transform coffee, endCoffee;
    public float lerpSpeed;

    public bool start;
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Taza")
        {
            coffee.gameObject.SetActive(true);
            start = true;

            Debug.Log(other.transform.tag);
        }
        else {

            start = false;
        }
    }

    private void Update()
    {

        if (coffee.transform.localPosition.y > 1.01644f) {

            gameObject.SetActive(false);
        
        }
        if (start) {

            coffee.transform.localPosition = Vector3.Lerp(coffee.transform.localPosition, new Vector3(-0.0520000011f, 1.04200006f, 0.178000003f), lerpSpeed * Time.deltaTime);
        }
    }
}
