using UnityEngine;

public class LearnIf : MonoBehaviour
{
    // 判斷式 if單獨使用
    // 判斷 布林值 來決定要執行哪種程式
    // 範例:
    // 判斷 玩家是否死亡 顯示遊戲結束

    private void Start()
    {
        // 語法:
        // 如果(布林值){程式內容}
        // 當布林值等於true時才會執行{}內容
        if (true)
        {
            print("我是判斷式:p");
        }
        
    }
    public bool open;

    public int score = 100;
    private void Update()
    {
        //語法:
        //否則{程式內容}
        if (open)
        {
            print("開門!!!");
        }
        else
        {
            print("關門!!!");
        }

        // 如果 分數 大於等於 60 就及格
        // 如果 分數 大於等於 40 就補考
        // 否則 當掉
        // 語法:
        // 否則 如果(布林值){程式內容}
        // 比較運算子 >= 結果為布林值
        //※ else if 必須寫在if之下、else之下，不限數量

        if (score >= 60)
        {
            print("及格");
        }
        else if (score >= 40)
        {
            print("你可以補考~");
        }
        else if (score >= 20)
        {
            print("付錢就讓你補考");
        }
        else
        {
            print("你被當掉惹!!!");
        }
    }
}
