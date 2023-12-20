using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : Singleton<GameplayManager>
{
    [Header("Transforms and Positions")]
    [SerializeField] Transform groundParentTf;
    [SerializeField] Transform playerSpawnPos;
    [SerializeField] Transform startPillarPos;

    [Header("Prefabs")]
    [SerializeField] Player playerPrefab;
    [SerializeField] GameObject startPillarPrefab;

    private Player player;
    public Player Player => player;

    private void Start()
    {
        OnStartPlay();
    }

    public void OnStartPlay()
    {
        Instantiate(startPillarPrefab, startPillarPos.position, Quaternion.identity, groundParentTf);
    }
}
