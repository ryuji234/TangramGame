using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public static partial class GF
{
    //! �ؽ�Ʈ�޽����� ������ ������Ʈ�� 
    public static void SetTextMeshPro(this GameObject obj_, string text_)
    {
        Text tmptext = obj_.GetComponent<Text>();
        if(tmptext == null || tmptext == default(Text))
        {
            return;
        }       // if: ������ �ؽ�Ʈ�޽� ������Ʈ�� ���� ���

        // ������ �ؽ�Ʈ�޽� ������Ʈ�� �����ϴ� ���
        tmptext.text = text_;
    }
}
