using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEnd : MonoBehaviour
{
    public int picnicItemCount = 0;
    public float speed = 1f;

    public Transform newTransform;
    public AudioSource doorOpener;
    public GameObject efeuwand;
    
    // Udate is called once per frame
    void Update()
    {
        if (picnicItemCount == 4)
        {
            openDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "picknickobject")
        {
            picnicItemCount += picnicItemCount;
            Debug.Log(picnicItemCount);
        }
    }

    void openDoor ()
    {
        efeuwand.transform.position = Vector3.MoveTowards(efeuwand.transform.position, newTransform.position, speed);
    }
}
