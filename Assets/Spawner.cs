using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject prefab;
	public List<GameObject> ballList = new List<GameObject>();

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject ball = Instantiate(prefab, new Vector3(Random.Range(-5f, 5f), 5, 0), Quaternion.identity);
			ballList.Add(ball);
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			foreach(GameObject ball in ballList)
			{
				ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-4f, 4f), 10f);
				ball.GetComponent<SpriteRenderer>().color = Color.red;
			}
			ballList.Clear();
		}
	}
}
