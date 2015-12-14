using UnityEngine;
using System.Collections;

/// <summary>
/// Interface for each robot game object.
/// </summary>
public interface IRobot {

	/// <summary>
	/// Moves the towards target.
	/// </summary>
	void MoveTowardsTarget();

	/// <summary>
	/// Gets the collision.
	/// </summary>
	/// <returns><c>true</c>, if collision was gotten, <c>false</c> otherwise.</returns>
	bool GetCollision();

	/// <summary>
	/// Sets the initial position.
	/// </summary>
	void SetInitialPosition();

	/// <summary>
	/// Moves the robot forward.
	/// </summary>
	/// <returns><c>true</c>, if forward was moved, <c>false</c> otherwise.</returns>
	bool MoveForward();

	/// <summary>
	/// Rotates the robot right.
	/// </summary>
	void RotateRight();

	/// <summary>
	/// Rotates the robot left.
	/// </summary>
	void RotateLeft();

	/// <summary>
	/// Updates the sprite.
	/// </summary>
	void UpdateSprite();

	/// <summary>
	/// Gets the position.
	/// </summary>
	/// <returns>The position.</returns>
	Vector3 GetPosition();

	/// <summary>
	/// Gets the rotation.
	/// </summary>
	/// <returns>The rotation.</returns>
	int[] GetRotation();

	/// <summary>
	/// Sets the rotation.
	/// </summary>
	/// <param name="rotation">Rotation.</param>
	void SetRotation(int[] rotation);

}
