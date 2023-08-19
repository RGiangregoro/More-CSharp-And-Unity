using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // jump location support
    const float minX = -4;
    const float maxX = 4;
    const float minY = -4;
    const float maxY = 4;

    // timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;

    // Update is called once per frame
    void Update()
    {
        // update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);
            transform.position = position;
        }

    }
}
