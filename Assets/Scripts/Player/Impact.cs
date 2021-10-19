using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            _particleSystem.Play();
    }
}
