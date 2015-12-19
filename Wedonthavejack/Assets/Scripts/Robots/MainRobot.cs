using UnityEngine;
using System.Collections;


/// <summary>
/// Script for the main robot of the game.
/// </summary>
public class MainRobot : MonoBehaviour, IRobot {
	public static Vector3 initialPos;
	public float moveDistance;
	public Sprite[] mainRobotSprites;
	public static int dx;
	public static int dy;
	private float speed;
	private bool collision;
	private static Vector3 currentPos;
	private static Vector3 nextPos;
	private static Vector3 targetPos;

	// Use this for initialization
	void Start () {
		currentPos = transform.position;
		initialPos = transform.position;
		targetPos = initialPos;
		speed = 5;
		//TODO add Sprite set and rotation set
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Moves the towards target. Called every frame.
	/// </summary>
	public void MoveTowardsTarget() {
		Vector3 currentPosition = transform.position;

		if (Vector3.Distance (currentPosition, targetPos) > .1f) { 
			Vector3 directionOfTravel = targetPos - currentPosition;
			//now normalize the direction, since we only want the direction information
			directionOfTravel.Normalize ();
			//scale the movement on each axis by the directionOfTravel vector components
			
			transform.Translate (
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
		} else {
			transform.position = targetPos;
		}
	}

	/// <summary>
	/// Sets the target position to the position to the move distance in front of the robot.
	/// </summary>
	public void MoveForward() {
		currentPos = transform.position;
		float nextX = currentPos.x + (dx * moveDistance);
		float nextY = currentPos.y + (dy * moveDistance);

		Vector3 next = new Vector3 (nextX, nextY);
		targetPos = next;
	}

	/// <summary>
	/// Rotates the robot right.
	/// </summary>
	public void RotateRight() {
		int tmp = dx;
		dx = dy;
		dy = -tmp;
	}

	/// <summary>
	/// Rotates the robot left.
	/// </summary>
	public void RotateLeft() {
		int tmp = dy;
		dy = dx;
		dx = -tmp;
	}

	/// <summary>
	/// Updates the sprite.
	/// </summary>
	public void UpdateSprite() {
		//TODO
	}

	/// <summary>
	/// Sets the initial position.
	/// </summary>
	public void SetInitialPosition() {
		currentPos = initialPos;
	}

	/// <summary>
	/// Sets the rotation.
	/// </summary>
	/// <param name="rotation">Rotation.</param>
	public void SetRotation(int[] rotation) {
		dx = rotation [0];
		dy = rotation [1];
	}

	/// <summary>
	/// Gets the position.
	/// </summary>
	/// <returns>The position.</returns>
	public Vector3 GetPosition() {
		return currentPos;
	}

	/// <summary>
	/// Gets the rotation.
	/// </summary>
	/// <returns>The rotation.</returns>
	public int[] GetRotation() {
		return new int[]{dx, dy};
	}

	/// <summary>
	/// Gets the collision.
	/// </summary>
	/// <returns>true</returns>
	/// <c>false</c>
	public bool GetCollision() {
		return collision;
	}
}
