using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObject;
   
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            uiObject.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            uiObject.SetActive(false);
    }
}
