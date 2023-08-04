using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEndFlag : MonoBehaviour
using UnityEngine;

public class FollowEndFlag : MonoBehaviour
{
    public Transform endFlag;

    private void Update()
    {
        if (endFlag != null)
        {
            // Make the camera look at the end flag's position
            transform.LookAt(endFlag);
        }
    }
}
