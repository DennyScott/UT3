using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public enum PlayerState { X, O }

	public PlayerState CurrentState;

	// Use this for initialization
	void Start () {
		CurrentState = PlayerState.X;
	}

	public void NextPlayer() {
		switch (CurrentState) {
			case PlayerState.X:
				CurrentState = PlayerState.O;
				break;
			case PlayerState.O:
				CurrentState = PlayerState.X;
				break;
		}
	}
}
