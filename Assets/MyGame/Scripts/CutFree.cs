using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFree : MonoBehaviour
{
    public AudioSource cutBush;
    public GameObject Efeuwand;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gartenschere")
        {
            cutBush.Play();
            Destroy(Efeuwand);
        }
    }
}
