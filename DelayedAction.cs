using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAction : MonoBehaviour
{
    public IEnumerator DelayEvent(float waitTime, System.Action delayedAction)
    {
        yield return new WaitForSeconds(waitTime);
        delayedAction();
    }
}
