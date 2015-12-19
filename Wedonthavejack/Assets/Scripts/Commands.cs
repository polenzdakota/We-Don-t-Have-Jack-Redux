using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Commands : MonoBehaviour {
	public GameObject currentRobot;
	private IList<IAction> actions;

	// Use this for initialization
	void Start () {
		actions = new List<IAction> ();
		currentRobot = GameObject.FindGameObjectWithTag ("Player");
	}

	public void AddAction(IAction addedAction) {
		actions.Add (addedAction);
	}

	public void ExecuteActions() {
		float secToWait = 0.5f;
		foreach (IAction action in actions) {
			StartCoroutine(TimeThenAction(secToWait, action));
			secToWait += 0.5f;
		}
	}

	IEnumerator TimeThenAction(float sec, IAction action) {
		yield return new WaitForSeconds (sec);
		action.InvokeAction ();
	}
}
