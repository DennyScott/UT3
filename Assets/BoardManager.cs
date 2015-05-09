using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour {

	public System.Action<GameObject> OnPlayerMove;

	public void PlayerMove(Text box) {
		switch (Managers.PlayerManager.CurrentState) {
			case PlayerManager.PlayerState.X:
				box.text = "X";
				break;
			case PlayerManager.PlayerState.O:
				box.text = "O";
				break;
		}
		TriggerOnPlayerMove(box.gameObject);
		Managers.PlayerManager.NextPlayer();
	}

	void TriggerOnPlayerMove(GameObject g) {
		if (OnPlayerMove != null) {
			OnPlayerMove(g);
		}
	}

}
