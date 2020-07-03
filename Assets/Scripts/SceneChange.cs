using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    bool portalEntered = false;


    /*private void Update()
    {
        portalEntered = false;
    }*/


    private void OnTriggerEnter(Collider other)
    {
        portalEntered = true;
    }

    public bool getPortalEntered()
    {
        return portalEntered;
    }
}
