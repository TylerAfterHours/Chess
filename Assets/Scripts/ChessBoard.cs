using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour {

	public Transform[,] spacePositions = new Transform[8,8];
	public GameObject[,] boardSpaces = new GameObject[8,8];
	public Pawn selectedPiece;
    public GameObject chessBoard; 

	// Use this for initialization
	void Start () {
        //initialize all the spaces of the chessboard into our array
        for (int i = 0; i < 8; i++) {
            for (int j = 0; i < 8; i++){

                boardSpaces[i, j] = chessBoard.Find(i.ToString()).Find(j.ToString());

            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void unhighlightSpaces () {
		for (var i = 0; i < 8; i++) {
			for (var j = 0; j < 8; j++) {
                boardSpaces[i, j].GetComponent<Space>().highlighted = false;
            }
		}
	}
}
