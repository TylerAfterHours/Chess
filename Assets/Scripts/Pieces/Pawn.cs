using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour {

	public bool isWhite;
	public bool selected;
	public int[] coordinates = new int[2];
	public Transform position;
	private int moveIncrement;
	private GameObject chessBoard;
	private ChessBoard boardScript;

	// Use this for initialization
	void Start () {
		moveIncrement = isWhite ? 1 : -1;
		chessBoard = GameObject.Find("ChessBoard");
		boardScript = chessBoard.GetComponent<ChessBoard>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {

		boardScript.selectedPiece.selected = false;

		boardScript.selectedPiece = this;

		boardScript.unhighlightSpaces();

		boardScript.boardSpaces[coordinates[0], coordinates[1] + moveIncrement].highlighted = true;
		if ((isWhite && coordinates [1] == 1) || (!isWhite && coordinates [1] == 6)) {
			boardScript.boardSpaces[coordinates[0], coordinates[1] + (moveIncrement * 2)].highlighted = true;
		}
	}
}
