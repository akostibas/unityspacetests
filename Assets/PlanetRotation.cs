using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour
{
	[SerializeField]
	private float RotationSpeed = 5;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (0, RotationSpeed * Time.deltaTime, 0);
	}
}
