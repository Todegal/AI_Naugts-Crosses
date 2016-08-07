using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

	int x, y;
	enum state { NAUGHT, CROSS, EMPTY };
	state type = EMPTY;

	public Cell(int x, int y, state type) {
		this.x = x;
		this.y = y;
		this.type = type;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
