using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHeadMover : MonoBehaviour {

	public Transform startPoint;
	public Transform endPoint;

	public void MovePlayhead (double playedFraction) {

		transform.position = Vector3.Lerp (startPoint.position, endPoint.position, (float) playedFraction);

	}
}
