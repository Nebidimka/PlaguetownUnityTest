using UnityEngine;
using System.Collections;

public class Apothecary : NPC {

   /* public GameObject node;
    public Vector3 direction;
    public float speed;

    public void Activate(GameObject node) {
        this.node = node.GetComponent<NodeConnection>().connections[(int)Random.Range(0,(int)node.GetComponent<NodeConnection>().connections.Length)];
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (node != null){
            direction = node.transform.position - this.transform.position;
            direction.Normalize();
            direction = direction * speed * Time.deltaTime;
            if (Vector3.Distance(node.transform.position, this.transform.position) > direction.magnitude)
                this.transform.position += direction;
            else {
                this.transform.position = node.transform.position;
                this.node = node.GetComponent<NodeConnection>().connections[(int)Random.Range(0, (int)node.GetComponent<NodeConnection>().connections.Length)];
            }
        }

	
	}*/
}
