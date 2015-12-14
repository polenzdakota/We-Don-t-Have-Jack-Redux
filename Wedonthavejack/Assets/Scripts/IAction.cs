using UnityEngine;
using System.Collections;

/// <summary>
/// Interface for action commands.
/// </summary>
public interface IAction {

	/// <summary>
	/// Invokes the action.
	/// </summary>
	/// <returns><c>true</c>, if action was invoked, <c>false</c> otherwise.</returns>
	bool InvokeAction();

	/// <summary>
	/// Undos the action.
	/// </summary>
	/// <returns><c>true</c>, if action was undone, <c>false</c> otherwise.</returns>
	bool UndoAction();
}
