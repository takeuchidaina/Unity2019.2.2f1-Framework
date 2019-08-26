using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFPS : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 60; //60FPSに設定

        /*
         * プロジェクトの設定でFPS値の垂直同期を切っておかないとだめ
         * 確認方法
         * "Edit"→"Project Settings"→"Quality"を選んで、インスペクターから"VSync Count"
         * ドロップダウンメニューから"Don't Sync"（垂直同期無し）を選ぶ。
         * 参考URL：http://unityleaning.blog.fc2.com/blog-entry-2.html
         */
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
