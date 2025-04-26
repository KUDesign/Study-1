using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UXF;

public class activateEndTrigger : MonoBehaviour
{
	//Activates the final trigger when walking back
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("Subject"))
		{
			{
				
				

			}
		}
	}
}
