﻿using UnityEngine;
using System.Collections;

public class enemy2 : MonoBehaviour {



  // Use this for initialization
  void Start () {

    StartCoroutine ("Move");
  }

  // Update is called once per frame
  void Update () {

    transform.Translate(Vector3.forward * 80f * Time.deltaTime); 
  }

  IEnumerator Move() {


    while (true) {
      yield return new WaitForSeconds (6.5f);
      transform.eulerAngles += new Vector3 (0, 180f, 0);
    }
  }
}