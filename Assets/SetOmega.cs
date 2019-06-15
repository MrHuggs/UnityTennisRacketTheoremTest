using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOmega : MonoBehaviour
{
	Rigidbody rb;
	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();


		Debug.Log(string.Format("Inertia tensor ({0}, {1}, {2})",
						rb.inertiaTensor.x, rb.inertiaTensor.y, rb.inertiaTensor.z));
		rb.angularVelocity = new Vector3(0, 10, 1);
		Debug.Log(string.Format("Initial omega = ({0}, {1}, {2})",
						rb.angularVelocity.x, rb.angularVelocity.y, rb.angularVelocity.z));
	}

	// Update is called once per frame
	void Update()
    {
		Debug.Log(string.Format("omega = ({0}, {1}, {2})",
						rb.angularVelocity.x, rb.angularVelocity.y, rb.angularVelocity.z));
	}
}
