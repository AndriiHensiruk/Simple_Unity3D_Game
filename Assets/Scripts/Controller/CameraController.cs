using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 newpos;

    public GameObject player;

    private void Start()
    {
        offset = player.transform.position - transform.position;
    }

    private void Update()
    {
        newpos = transform.position;
        newpos.x = player.transform.position.x - offset.x;
        newpos.z = player.transform.position.z - offset.z;
        transform.position = newpos;
    }
}
