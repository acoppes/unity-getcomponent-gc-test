using UnityEngine;
using System.Collections;

public class GetComponentBehaviour : MonoBehaviour
{
	void Update()
	{
		for (int i = 0; i < 5000; i++) {
			AnotherBehaviour component = this.GetComponent<AnotherBehaviour>();
		}
	}
}

