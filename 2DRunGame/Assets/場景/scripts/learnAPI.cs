using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // 非靜態成員需要
    // 1.實體物件或元件(Unity階層面板)
    // 2.欄位
    //先看場景上有的物件與元件
    public GameObject sphere;

    public Transform tra;

    public Transform cube;

    public Light myLight;
    
    public Camera cam; 

    private void Start()

    
    {
        //取得屬性peoperties
        //※※※※※ 語法:
        // 欄位名稱、屬性

        print(sphere.layer);

        print("球的座標:" + tra.position);

        //取得屬性peoperties
        //※※※※※ 語法:
        // 欄位名稱、屬性 = 值


        tra.localScale = new Vector3(7, 7, 7);

        // 練習:
        // 1.控制燈光顏色為紅色 light
        //myLight.color = Color.red;
        myLight.color = new Color(0.8f, 0, 0);
        // 2.設定燈光恢復預設值 light
        myLight.Reset();
    
        // 3.調整攝影機的尺寸 3 Camera
   
    }

    private void Update()
    {
        cube.Rotate(0, 0, 1);

    }
}
