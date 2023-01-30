using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public static partial class GF
{
    //! 텍스트메쉬프로 형태의 컴포넌트의 
    public static void SetTextMeshPro(this GameObject obj_, string text_)
    {
        Text tmptext = obj_.GetComponent<Text>();
        if(tmptext == null || tmptext == default(Text))
        {
            return;
        }       // if: 가져올 텍스트메쉬 컴포넌트가 없는 경우

        // 가져올 텍스트메쉬 컴포넌트가 존재하는 경우
        tmptext.text = text_;
    }
}
