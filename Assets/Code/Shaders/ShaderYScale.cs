﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderYScale : MonoBehaviour
{
  Material material;

  protected void Start()
  {
    material = GetComponentInChildren<MeshRenderer>().material;
    material.SetFloat("_RngSeed", UnityEngine.Random.value * 999); 
  }

  void Update()
  {
    material.SetFloat("_Scale", transform.localScale.y);
    material.SetFloat("_XScale", transform.localScale.x);
  }
}
