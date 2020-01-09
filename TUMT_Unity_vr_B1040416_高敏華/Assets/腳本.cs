using UnityEngine;

public class 腳本 : MonoBehaviour
{
    //公開必且參數零或是一個 
    public void ThrowPickUp()
    {
        print("撿起物件");
    }

    public void ThrowDetach()
    {
        print("放開物件");
    }

    public void ThrowHeld()
    {
        print("拿起物件");
    }
}
