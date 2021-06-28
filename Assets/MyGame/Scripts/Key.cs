using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Transform newTransform;
    public GameObject efeuwand;
    public AudioSource doorOpener;
    public float speed = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            openDoor();
            doorOpener.Play();
        }
    }

    void openDoor()
    {
        efeuwand.transform.position = Vector3.MoveTowards(efeuwand.transform.position, newTransform.position, speed);
    }
}
