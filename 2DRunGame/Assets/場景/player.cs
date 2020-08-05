using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;
    [Header("跳越高度"), Range(0, 1000)]
    public int jump = 350;
    [Header("血量"), Range(0, 2000)]
    public float hp = 500;

    public bool isGround;
    public int coin;

    [Header("音效區域")]
    public AudioClip soundHit;
    public AudioClip soundSlide;
    public AudioClip soundJump;
    public AudioClip soundCoin;

    public Animator ani;
    public Rigidbody2D rig;
    public CapsuleCollider2D cap;
    public AudioSource aud;
    //[ public Transform tra; ]寫不寫都可以，因為本來就有這個欄位
    #endregion

    #region 方法
    /// <summary>
    ///  移動
    /// </summary> 
    private void Move()
    {
        // Time.deltaTime 跑一禎的時間
        // Update 內移動、旋轉、運動
        // 避免裝置不同執行速度不同
        transform.Translate(speed * Time.deltaTime, 0, 0); //變形.位移(X, Y, Z)
    }
    
    /// <summary>
    ///  跳躍
    /// </summary>
    private void Jump()
    {
        // 布林值 = 輸入.按下按鍵(按鍵列舉.空白鍵)
        bool space = Input.GetKeyDown(KeyCode.Space);

        // 2D 射線碰撞物件 = 2D 物理.射線碰撞(起點，方向，長度)
        //圖層語法:1 << 圖層編號
        RaycastHit2D hit = Physics2D. Raycast(transform.position + new Vector3(-0.05f, -2.03f), -transform.up, 0.01f, 1 << 8 );

        if (hit)
        {
            isGround = true;
            ani.SetBool("跳躍開關", false);
        }
        else
        {
            isGround = false;

        }



        if (isGround)
        {
            if (space)
            {
                //動畫控制器.設定布林值("參數名稱"，布林值)
                ani.SetBool("跳躍開關", true);
                //剛體.添加推力(二維向量)
                rig.AddForce(new Vector2(0, jump));
                //是否在地板上 = 否
                aud.PlayOneShot(soundJump, 0.5f);
            }
       
        }

        
        
       
    }

    /// <summary>
    ///  滑行
    /// </summary>
    private void Slide()
    {
        bool ctrl = Input.GetKey(KeyCode.LeftControl);

        ani.SetBool("滑行開關", ctrl);
        //如果判斷物的程式內容只有一行，可以省略大括號
        if (Input.GetKeyDown(KeyCode.LeftControl)) aud.PlayOneShot(soundSlide, 0.5f);
        if (ctrl)
        {
            cap.offset = new Vector2(-0.1f, -0.3f);
            cap.size = new Vector2(2f, 4.8f);
        }
        else
        {
            cap.offset = new Vector2(-0.1f, -1.68f);
            cap.size = new Vector2(2f, 2f);
        }
        // 如果 按下 ctrl
        // 滑行 位移 
        // 否則
        // 站立 位移-0.1 -0.3 尺寸 2 4.8
        // 滑行 位移-0.1 -1.68 尺寸 2 2

        
           
        
    }

    /// <summary>
    ///  吃金幣
    /// </summary>
    private void Coin()
    {

    }

    /// <summary>
    ///  受傷
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    ///  死亡
    /// </summary>
    private void Die()
    {

    }

    /// <summary>
    ///  過關
    /// </summary>
    private void Clear()
    {

    }
    #endregion

    #region 事件
    private void Start()
    {
    }

    private void Update()
    
    {
        Jump();
        Slide();
        Move();
    }

    //繪製圖示事件:繪製輔助線條，僅在 Scene 看得到
    private void OnDrawGizmos()
    {
        //圖示.顏色 = 顏色.紅色
        Gizmos.color = Color.red;
        //圖示.繪製射線(起點，方向)
        // transform 此物件的變形元件
        // transform.position 此物件的座標
        // transform.up        此物件上方 Y預設為1
        // transform.right     此物件右方 Y預設為1
        // transform.forward   此物件前方 Z預設為1
        Gizmos.DrawRay(transform.position + new Vector3(-0.05f, -2.03f), -transform.up * 0.01f);
    }

    #endregion
}
