using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    //[SerializeField] Level[] levels;
    //public Level currentLevel;

    public void Start()
    {
        OnLoadLevel(0);
        OnInit();
    }

    //khoi tao trang thai bat dau game
    public void OnInit()
    {
        //player.OnInit();
    }

    //reset trang thai khi ket thuc game
    public void OnReset()
    {
        
    }

    //tao prefab level moi
    public void OnLoadLevel(int level)
    {
        //if (currentLevel != null)
        //{
        //    Destroy(currentLevel.gameObject);
        //}

        //currentLevel = Instantiate(levels[level]);
    }

}