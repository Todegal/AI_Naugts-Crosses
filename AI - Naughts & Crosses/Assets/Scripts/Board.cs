using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {

	Cell[][] cells = new Cell[3][3];

	public Board() {
		for (int i = 0; i <= 2; i++) {
			for (int j = 0; j <= 2; j++) {
				cells [i] [j] = new Cell (i, j, Cell.state.EMPTY);
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
