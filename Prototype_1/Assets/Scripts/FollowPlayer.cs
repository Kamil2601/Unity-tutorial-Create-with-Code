using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private readonly Vector3 tpp = new Vector3(0,5,-7);
    private readonly Vector3 fpp = new Vector3(0, 2.5f, 1);
    private Vector3 offset = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        offset = tpp;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetKeyDown("p"))
        {
            if (offset == tpp)
                offset = fpp;
            else
                offset = tpp;
        }
    }
}
