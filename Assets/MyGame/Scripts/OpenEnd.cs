using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEnd : MonoBehaviour
{
    public int picnicItemCount = 0;

    public AudioSource doorOpener;
    public GameObject efeuwand;
    
    // Udate is called once per frame
    void Update()
    {
        if (picnicItemCount == 4)
        {

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
}
