using System.Collections;
using UnityEngine;

public class FreezePosition : MonoBehaviour
{
    private float freezeTime = 1.0f;

    public void FreezeEvent()
    {
        StartCoroutine(FreezeXAfterDelay());
    }


    private IEnumerator FreezeXAfterDelay()
    {
        yield return new WaitForSeconds(freezeTime);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionX | rb.constraints;
    }
}
