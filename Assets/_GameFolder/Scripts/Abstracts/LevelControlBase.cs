using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelControlBase
{
    public abstract void IsLeveltriggered(Collider other);
    // public abstract event System.Action<int> isLeveltriggered;
    public abstract event System.Action isFinishtriggered;
}
