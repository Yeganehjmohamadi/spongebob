using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
 public Movement movement;

 public GameObject camera;

 public TextMeshPro nicknameText;
public void IsLocalPlayer(){
    movement.enabled = true;
    camera.SetActive(true);
}

}