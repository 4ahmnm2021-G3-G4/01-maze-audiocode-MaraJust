using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFree : MonoBehaviour
{
    public AudioSource cutBush;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gartenschere")
        {
            cutBush.Play();
            Destroy(gameObject);
        }
    }
}
