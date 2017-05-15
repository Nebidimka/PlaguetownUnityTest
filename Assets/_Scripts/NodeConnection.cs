using UnityEngine;
using System.Collections;

public class NodeConnection : MonoBehaviour {
    
	public GameObject[] connections;
    public GameObject NPC;
    GameObject firstCitizen;
    public float areaSideSize = 1f;
	public bool showAOEGizmo = true;

	public float arrowSizeScaler = 4f;

	// Use this for initialization
	void Start () {
        if (NPC != null){
            firstCitizen = Instantiate(NPC, transform.position, transform.rotation) as GameObject;
            firstCitizen.GetComponent<NPC>().Activate(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnDrawGizmos() {
		Gizmos.color = new Color(0, 1f, 0, 1f);

		//aoe square
		if(showAOEGizmo)
			Gizmos.DrawCube (this.transform.position, new Vector3(areaSideSize, 0f, areaSideSize));


		Gizmos.color = new Color(0.7f, 0.2f, 0.2f, 1f);
		for (int i = 0; i < connections.Length; i++) {
			if (connections [i] != null) {
				//mid point of connection vector
				Vector3 midPoint = new Vector3((this.transform.position.x + connections [i].transform.position.x)/2f,
					(this.transform.position.y + connections [i].transform.position.y)/2f,
					(this.transform.position.z + connections [i].transform.position.z)/2f);

				//direction of the vector, resized
				Vector3 direction = (this.transform.position - connections [i].transform.position).normalized / arrowSizeScaler;

				//calculations to get cross (vector, y plane)
				Vector3 vertical = midPoint + Vector3.up;
				Vector3 side1 = vertical - midPoint;
				Vector3 side2 = this.transform.position - midPoint;

				Vector3 perp = (Vector3.Cross (side1, side2).normalized) / arrowSizeScaler; //(0.25f) size

				//arrow
				Gizmos.DrawLine (midPoint + (perp) - direction, midPoint - (perp) - direction);
				Gizmos.DrawLine (midPoint - direction*2, midPoint + (perp) - direction);
				Gizmos.DrawLine (midPoint - direction*2, midPoint - (perp) - direction);

				//connection
				Gizmos.DrawLine (this.transform.position, connections[i].transform.position);

				//little node circle
				Gizmos.DrawWireSphere(this.transform.position, 0.3f);
			}
		}
	}
}
