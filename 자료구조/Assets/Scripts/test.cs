using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class test : MonoBehaviour
{
    public class TestNode<T>
    {
        public TestNode<T> Next { get; set; }

    }
    //링크드리스트 기능.

    private TestNode<T> head;
    private int count;


    public void Add(T data)

    {
        //헤드 다음 추가.
    }

    public void Remove(TestNode<ST> node /* 인덱스, 값*/)

    {
        //삭제
        //검색, 삭제 
        while () ;
       {
            //next next
       }
    }

    public TestNode<T> Find(T value)
    {
        //검색
        while()
        {
            //next next;
        }
        return new TestNode<T>();
    }
}
