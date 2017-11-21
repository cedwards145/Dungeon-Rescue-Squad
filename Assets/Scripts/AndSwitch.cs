using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndSwitch : Switch
{
    public Switch[] switches;

    public override bool IsOn()
    {
        foreach (Switch s in switches)
        {
            if (!s.IsOn())
            {
                return false;
            }
        }

        return true;
    }
}