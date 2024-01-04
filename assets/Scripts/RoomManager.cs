using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{

    public GameObject player;

    [Space]
    public Transform  spawnPoint;

    void Start()
    {
        Debug.Log("Connecting...");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster() {
        base.OnConnectedToMaster();

        Debug.Log("Connected To Server!");

        PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        PhotonNetwork.JoinOrCreateRoom("test", null , null);

        Debug.Log("We're Connected and in a room now!");

        Invoke("PhotonInit", 3);
    }

    void PhotonInit() {

       GameObject _player = PhotonNetwork.Instantiate (player.name, spawnPoint.position,Quaternion.identity);

    }

}