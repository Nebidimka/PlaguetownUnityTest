using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour {

	private GameObject[] _children;

	// Use this for initialization
	void Start () {

		int numChildren = transform.childCount;

		_children = new GameObject[numChildren];

		for (int i = 0; i < numChildren; i++) {
			_children [i] = transform.GetChild (i).gameObject;
			print("child " + i + "; coor: " + _children[i].transform.position.x + " : " + _children[i].transform.position.z + "   " + _children [i].GetComponent<NodeConnection> ().connections.Length);
		}

	}
	
	// Update is called once per frame
	void Update () {
	}
}
