using UnityEngine;
using UnityEngine.UIElements;

public class Cameracontrol : MonoBehaviour
{
    [Header("目標:要追蹤的物件")]
    public Transform target;
    [Header("追蹤速度"), Range(0, 100)]
    public float speed = 1;
    //下限-0.5 上限-0.15
    [Header("攝影機拍攝的上限與下限")]
    public Vector2 limit = new Vector2(-0.5f, -0.15f);

    /// <summary>
    /// 追蹤
    /// </summary>
    private void Track()
    {
        Vector3 posA = transform.position;
        Vector3 posB = target.position;

        posB.z = -10;
        posB.y = Mathf.Clamp(posB.y, limit.x, limit.y);
        posA = Vector3.Lerp(posA, posB, speed * Time.deltaTime);

        transform.position = posA;
    
    }

    //Late Update 在 Update 後執行，攝影機追蹤
    private void LateUpdate()
    {
        Track();
    }
}
