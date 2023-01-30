using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
public static partial class GF
{
    //! Ư�� ������Ʈ�� �ڽ� ������Ʈ�� ��ġ�ؼ� ã���ִ� �Լ�
    public static GameObject FindChildObj(this GameObject targetObj_, string objName_)
    {
        GameObject searchResult = default;
        GameObject searchTarget = default;
        for(int i=0;i < targetObj_.transform.childCount;i++)
        {
            searchTarget = targetObj_.transform.GetChild(i).gameObject;
            if(searchTarget.name.Equals(objName_)) 
            {
                searchResult = searchTarget;
                return searchResult;
            }
            else
            {
                searchResult = FindChildObj(searchTarget, objName_);
            }
        }       //loop

        return searchResult;
    }           // FindChildobj()
    //! Ư�� ������Ʈ�� �ڽ� ������Ʈ�� ��ġ�ؼ� ã���ִ� �Լ�
    //public static GameObject GetChildobj(this GameObject targetObj_, string objName_)
    //{
    //    GameObject searchResult = default;
    //    for (int i = 0; i< targetObj_.transform.childCount;i++)
    //    {
    //        if (targetObj_.transform.GetChild(i).gameObject.name.Equals(objName_))
    //        {
    //            searchResult = targetObj_.transform.GetChild(i).gameObject;
    //            return searchResult;
    //        }       //if: Ÿ�� ������Ʈ���� �̸��� ���� ������Ʈ�� ã�Ƽ� ����
    //        else { continue; }   
    //    }       //loop

    //    //�̸��� ���� ������Ʈ�� ã�� ���� ��� default ���� �����Ѵ�.
    //    return searchResult;
    //}       //GetChildobj
    //! ���� ��Ʈ ������Ʈ�� ��ġ�ؼ� ã���ִ� �Լ� 
    public static GameObject GetRootobj(string objName_)
    {
        Scene activeScene_ = GetActiveScene();
        GameObject[] rootObjs_ = activeScene_.GetRootGameObjects();
        GameObject targetObj_= default;
        foreach (GameObject rootobj in rootObjs_) 
        {
            if (rootobj.name.Equals(objName_))
            {
                targetObj_ = rootobj;
                return targetObj_;
            }
            else { continue; }
        }       //loop

        return targetObj_;
    }

    //! ���� Ȱ��ȸ �Ǿ� �ִ� ���� ã���ִ� �Լ�
    public static Scene GetActiveScene()
    {
        Scene activeScene_ = SceneManager.GetActiveScene();
        return activeScene_;
    }       //�÷����ϴ� ���� ã�´�.


    //!������Ʈ �������� �Լ�
    public static T GetComponentMust<T>(this GameObject obj)
    {
        T component_ = obj.GetComponent<T>();
        GF.Assert(component_.IsValid<T>() != false, string.Format("{0}���� {1}��(��) ã�� �� �����ϴ�.", obj.name, component_.GetType().Name));

        return component_;
    }       // GetComponentMust()
    
    //! Ʈ�������� ����ؼ� 2D������Ʈ�� �����̴� �Լ�
    public static void Translate(this Transform transform_, Vector2 moveVector)
    {
        transform_.Translate(moveVector.x, moveVector.y, 0f);
    }       //Translate() // Translate�� Vector3���� �ޱ� ������ Vector2�� ������ �ֵ��� �����ߴ�.

    //! RectTransform ���� sizeDelta�� ã�Ƽ� �����ϴ� �Լ�
    public static Vector2 GetRectSizeDelta(this GameObject obj_)
    {
       return obj_.GetComponentMust<RectTransform>().sizeDelta;
    }       //GetRectSizeDelta()

    //!������Ʈ�� ���� �������� �����ϴ� �Լ�
    public static void SetLocalpos(this GameObject obj_, float x, float y, float z)
    {
        obj_.transform.localPosition = new Vector3(x, y, z);
    }
    
    //! ������Ʈ�� ���� �������� �����ϴ� �Լ�
    public static void AddLocalPos(this GameObject obj_, float x, float y,float z)
    {
        obj_.transform.localPosition = obj_.transform.localPosition + new Vector3(x, y, z);
    }
}

