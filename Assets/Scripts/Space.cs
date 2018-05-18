using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour {

	public bool highlighted;
	public int[] coordinates = new int[2];
	private GameObject chessBoard;
	private ChessBoard boardScript;

	// Use this for initialization
	void Start () {
		highlighted = false;
		chessBoard = GameObject.Find("ChessBoard");
		boardScript = chessBoard.GetComponent<ChessBoard>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		if (highlighted) {
			boardScript.selectedPiece.coordinates = coordinates;
			boardScript.selectedPiece.position = boardScript.spacePositions [coordinates [0], coordinates [1]];
			boardScript.selectedPiece.selected = false;
			boardScript.selectedPiece = null;
		}
	}
}
