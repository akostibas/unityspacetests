using UnityEngine;
using System.Collections;

public class CreateStars : MonoBehaviour
{
	[SerializeField]
	private GameObject starPrefab;
	[SerializeField]
	private int numberOfStars = 100;

	void Start ()
	{
		Debug.Log ("Making " + numberOfStars + " stars.");
		for (int i = 0; i <= numberOfStars; i++) {
			float locationX = transform.localPosition.x + ((Random.value - 0.5f) * transform.localScale.x);
			float locationY = transform.localPosition.y + ((Random.value - 0.5f) * transform.localScale.y);
			float locationZ = transform.localPosition.z + ((Random.value - 0.5f) * transform.localScale.z);

			Vector3 position = new Vector3 (locationX, locationY, locationZ);
			var newStar = Instantiate (starPrefab,
				              position,
				              Quaternion.identity) as GameObject;
			newStar.transform.parent = transform;
		}
	}

	void Update ()
	{
	
	}
}
