using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //construtor
        //default constructor
        //constructor yazsan da yazmasan da arka tarafta çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            items = new T[items.Length + 1];
            T[] tempArray = items;
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        public int Count
        {
            get { return items.Length; }
        }

    }
}
//Ben MyListimde T ile çalışacağım.
//T demek "Bana bir type ver ben de aşağıyı ona göre yapılandırıyım"
//Bir class newlendiğinde çalışan bloğa construtor denir.
//MyList artık Generic Class oldu. Yani List<string> e benzetmeye çalıştık.
//List<string> in içinde Add komutu hazır bulunur ama Classı generic bir yapı yaparken Add metotunu eklemek gerekir.