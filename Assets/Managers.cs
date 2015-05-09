using UnityEngine;
using System.Collections;

public class Managers : MonoBehaviour {

	public static PlayerManager PlayerManager;
	public static BoardManager BoardManager;

	// Use this for initialization
	void Awake () {
		PlayerManager = GetComponentInChildren<PlayerManager>();
		BoardManager = GetComponentInChildren<BoardManager>();
	}
	

}
