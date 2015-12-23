using UnityEngine;
using System.Collections;

public class MainRotateRight : MonoBehaviour, IAction {

    /// <summary>
    /// Rotates the robot right.
    /// </summary>
    /// <returns></returns>
    public bool InvokeAction() {
        return false;
    }

    /// <summary>
    /// Undos the action
    /// </summary>
    /// <returns></returns>
    public bool UndoAction() {
        return false;
    }
}
