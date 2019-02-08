using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinFirstLevel : WinLevel
{
    public MouseControll firstLevelController;

    public override bool WinCondition()
    {
        return firstLevelController.object1.GetComponent<TouchedController>().wasTouched && firstLevelController.object2.GetComponent<TouchedController>().wasTouched;
    }

}
