using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float spinSpeed = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
