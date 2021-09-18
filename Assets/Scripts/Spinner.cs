using UnityEngine;

public class Spinner : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime, 0);
    }
}