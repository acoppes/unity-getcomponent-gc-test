using UnityEngine;
using System.Collections;

public class GetComponentBehaviour : MonoBehaviour
{
	int counter;
	
	// Use this for initialization
	void Start()
	{
		
	}
	
	void Update()
	{
		for (int i = 0; i < 5000; i++) {
			MyGetComponent(i);
		}
	}
	
	void MyGetComponent(int i)
	{
		AnotherBehaviour component = this.GetComponent<AnotherBehaviour>();
		counter++;
	}
}

