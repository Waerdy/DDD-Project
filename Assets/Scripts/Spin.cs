using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 spin;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(spin * 1 * Time.deltaTime);
    }
}
