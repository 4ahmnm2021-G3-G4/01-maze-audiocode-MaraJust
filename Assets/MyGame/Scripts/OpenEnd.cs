using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEnd : MonoBehaviour
{
    public int picnicItemCount = 0;
    public GameObject key;
    
    // Udate is called once per frame
    void Update()
    {
        if (picnicItemCount == 4)
        {
            key.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "picknickobject")
        {
            picnicItemCount += 1;
            Debug.Log(picnicItemCount);
        }
    }

   
}
