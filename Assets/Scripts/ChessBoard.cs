using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour {

	public Transform[,] spacePositions = new Transform[8,8];
	public Space[,] boardSpaces = new Space[8,8];
	public Pawn selectedPiece;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void unhighlightSpaces () {
		for (var i = 0; i < 8; i++) {
			for (var j = 0; j < 8; j++) {
				boardSpaces [i, j].highlighted = false;
			}
		}
	}
}
