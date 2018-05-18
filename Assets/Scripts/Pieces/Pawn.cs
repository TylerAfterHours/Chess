using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour {

	public bool isWhite;
	private int moveIncrement;
	private Transform position;
	private int[] coordinates = new int[2];
	private GameObject chessBoard = GameObject.Find("Board");
	private script boardScript = chessBoard.GetComponent("ChessBoard");

	// Use this for initialization
	void Start () {
		moveIncrement = isWhite ? 1 : -1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {

		boardScript.selectedPiece = this;

		boardScript.unhighlightSpaces();

		boardScript.boardSpaces[coordinates[0], coordinates[1] + moveIncrement].highlighted = true;
		if ((isWhite && coordinates [1] == 1) || (!isWhite && coordinates [1] == 6)) {
			boardScript.boardSpaces[coordinates[0], coordinates[1] + (moveIncrement * 2)].highlighted = true;
		}
	}
}
