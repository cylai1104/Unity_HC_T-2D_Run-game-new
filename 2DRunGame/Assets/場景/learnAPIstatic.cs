using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnAPIstatic : MonoBehaviour
{
    //認識API內有靜態(static)關鍵字的成員
    private void Start()
    {
        //【取得】靜態屬性語法 Static properties
        //※※※※※語法:
        //類別、靜態屬性
        //※Read only = 不能設定只能讀取(唯讀)
        //想設定唯讀的屬性(Random.value = 0.99f;)會發生錯誤
        print(Random.value);
        print(Mathf.PI);
        Time.timeScale = 10;

        float r = Random.Range(100.9f, 200.5f);
        print("隨機值:" + r);

        //整數包含minimum不包含maximum
        int ri = Random.Range(1, 3);
        print("隨機整數:" + ri);

        

        //練習:
        //隱藏滑鼠 - 指標 Cursor
        Cursor.visible = false;
        //-9取絕對值 - 數學
        print("-9的絕對值:" + Mathf.Abs(-9));
        //是否按下任意鍵 - 輸入Input

    }
    private void Update()

    {
        //print("遊戲時間:" + Time.time);

        //是否按下任意鍵 - 輸入 Input - true/false
        print("玩家是否按任意鍵:" + Input.anyKeyDown);

    }


}
