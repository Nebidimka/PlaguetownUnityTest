using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

    public bool infected;
    public GameObject node;
    public Vector3 direction;
    public float speed;

    public void Activate(GameObject node) {
        this.node = node;
        selectNewNode();
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update(){
        if (!infected){

        }
        if (node != null)
            move();
    }


	void move(){
            direction = node.transform.position - this.transform.position;
            direction.Normalize();
            direction = direction * speed * Time.deltaTime;
        if (Vector3.Distance(node.transform.position, this.transform.position) > direction.magnitude)
            this.transform.position += direction;
        else{
            this.transform.position = node.transform.position;
            selectNewNode();
        }
    }
    
    void selectNewNode(){
        this.node = node.GetComponent<NodeConnection>().connections[(int)Random.Range(0, (int)node.GetComponent<NodeConnection>().connections.Length)];
    }
}
