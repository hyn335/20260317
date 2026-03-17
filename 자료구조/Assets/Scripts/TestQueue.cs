using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class TestQueue /*<T>*/
{
    int[] items = new int[10];
    private int front = -1;
    private int rear = -1;

    private void Algorithm()
    {
        items[0] = 5;
        front = 0;
        rear = 0;

       
        int next = rear + 1 % items.Length;
        items[next] = 10;// 다음 데이터

        //if (가득 찬 상태인지 아닌지 

        if((rear + 1)% items.Length == front)
        {

            //가득 
        }

        //비어있는지 체크 

        front = (front + 1) % items.Length;

        if(front == rear)
        {
            front = -1;
            rear = -1;
        }

    }
}
