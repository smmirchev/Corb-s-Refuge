using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float HP = 100;
    public float damage = 5;

    bool isHardModeOn = false;

    public void setHardModeOn()
    {
        isHardModeOn = true;
    }

    public void setHardModeOff()
    {
        isHardModeOn = false;
    }

    private void Update()
    {
        if(isHardModeOn)
        {
            HardMode();
        }
        else
        {
            EasyMode();
        }
    }

    public void HardMode()
    {
        HP = 200;
        damage = 10;
    }

    public void EasyMode()
    {
        HP = 100;
        damage = 5;
    }
}
