using UnityEngine;
using System.Collections;

/// <summary>
/// Interface for Triggers
/// </summary>
public interface ITrigger{

	/// <summary>
	/// Envokes the trigger.
	/// </summary>
	void EnvokeTrigger();

	/// <summary>
	/// Devokes the trigger.
	/// </summary>
	void DevokeTrigger();

	/// <summary>
	/// Sets the action.
	/// </summary>
	void SetAction();
}
