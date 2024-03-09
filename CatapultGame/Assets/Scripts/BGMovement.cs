using System.Collections;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    public float speed;
    public GameObject background;

    private Coroutine movementCoroutine;

	
	public void startMovement()
	{
		StartCoroutine(MoveBackground());
	}

    IEnumerator MoveBackground()
    {
        while (true)
        {
            background.transform.Translate(Vector3.left * Time.deltaTime * speed);

            yield return null;
        }
    }
}
