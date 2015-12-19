using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Script contains all commands in a list and includes methods for
/// managing and executing said commands.
/// </summary>
public class Commands : MonoBehaviour {
	public GameObject currentRobot;
	private IList<IAction> actions;

	// Use this for initialization
	void Start () {
		actions = new List<IAction> ();
		currentRobot = GameObject.FindGameObjectWithTag ("Player");
	}

	/// <summary>
	/// Adds the action to the command list.
	/// </summary>
	/// <param name="addedAction">Added action.</param>
	public void AddAction(IAction addedAction) {
		actions.Add (addedAction);
	}

	/// <summary>
	/// Executes all actions in the list in 0.5 second intervals.
	/// </summary>
	public void ExecuteActions() {
		float secToWait = 0.5f;
		foreach (IAction action in actions) {
			StartCoroutine(TimeThenAction(secToWait, action));
			secToWait += 0.5f;
		}
	}

	/// <summary>
	/// Waits the given amount of time then executes the action.
	/// </summary>
	/// <returns>The then action.</returns>
	/// <param name="sec">Sec.</param>
	/// <param name="action">Action.</param>
	IEnumerator TimeThenAction(float sec, IAction action) {
		yield return new WaitForSeconds (sec);
		action.InvokeAction ();
	}
}
