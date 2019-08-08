using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            SoundEffectsManager.Instance.PlaySound("fire");
        }

        if (Input.GetButton("Fire1"))
        {
            SoundEffectsManager.Instance.PlaySound("alternate");
        }
    }
}
