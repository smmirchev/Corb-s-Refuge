using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    public Transform myPlayer;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(myPlayer);
    }
}
