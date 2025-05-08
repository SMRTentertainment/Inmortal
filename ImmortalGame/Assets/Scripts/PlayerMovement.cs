using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
private float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
