using UnityEngine;
using System.Collections;

public class InnerGridManager : MonoBehaviour {

	void Start() {
		Managers.BoardManager.OnPlayerMove += HandlePlayerMove;
	}

	void HandlePlayerMove(GameObject g) {
		Debug.Log("Check if 3 in a row");
	}
}
