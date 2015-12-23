using UnityEngine;
using System.Collections;

public class MainMoveForward : MonoBehaviour, IAction {

    /// <summary>
    /// Moves the robot forward
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
