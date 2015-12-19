using UnityEngine;
using System.Collections;

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

	public void MoveForward() {
		currentPos = transform.position;
		float nextX = currentPos.x + (dx * moveDistance);
		float nextY = currentPos.y + (dy * moveDistance);

		Vector3 next = new Vector3 (nextX, nextY);
		targetPos = next;
	}

	public void RotateRight() {
		int tmp = dx;
		dx = dy;
		dy = -tmp;
	}

	public void RotateLeft() {
		int tmp = dy;
		dy = dx;
		dx = -tmp;
	}

	public void UpdateSprite() {
		//TODO
	}

	public void SetInitialPosition() {
		currentPos = initialPos;
	}

	public void SetRotation(int[] rotation) {
		dx = rotation [0];
		dy = rotation [1];
	}

	public Vector3 GetPosition() {
		return currentPos;
	}

	public int[] GetRotation() {
		return new int[]{dx, dy};
	}

	public bool GetCollision() {
		return collision;
	}
}
