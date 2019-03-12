using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.	Создать индексатор для одномерного массива который 
при установке значения 
будет возводить в квадрат передаваемое 
значение переменной и устанавливать
его для указанного индекса. 
При получении элемента массива по индексу будет 
возвращаться его текущее значение 
*/
namespace HomeWorkIndex
{
    public class Index
    {
        int[] array;
        int size = 5;
        public Index()
        {
            array = new int[size];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value*value;
            }
        }
    }
}
