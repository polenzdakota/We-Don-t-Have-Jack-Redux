using UnityEngine;
using System.Collections;

public class MainRotateLeft : MonoBehaviour, IAction {

    /// <summary>
    /// Rotates the robot left
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
