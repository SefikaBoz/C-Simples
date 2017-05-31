# C-Simples


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Index i = new Index();
            i[5] = 30;
            i[2] = 65;
            Console.WriteLine(i[45]);
            Console.WriteLine(i[45]);
            Console.WriteLine(i[50]);

            //Indexer i = new Indexer();
            //Console.WriteLine("i[1.2]={0}",i[1.2]);
            //i[2] = 5;
            //Console.WriteLine(i.num);
            //i[5] = 8;
            //Console.WriteLine(i.num);
            //Console.WriteLine("i[5]={0} : ",i[5]);


            BookIndexer bi = new BookIndexer(10);

            bi[4] = 78;
            bi[2] = 4;
            Console.Write(bi[4]);

            //for (int j = 0; j < bi.ArraySize; j++)
            //{
            //    Console.WriteLine(bi[j]);
            //}

            Car c = new Car(1);
            for (int j = 0; j < c.ArrayCarSize; j++)
            {
                Console.WriteLine(j + ". element : " + c[j]);
            }


            // MultiDimensionalIndexerExamp test

            MultiDimensionalIndexerExamp mdi = new MultiDimensionalIndexerExamp(3, 4);

            for (int k = 0; k < mdi.Size1; k++)
            {
                for (int j = 0; j < mdi.Size2; j++)
                {
                    mdi[k, j] = k + j;
                }
            }
            for (int k = 0; k < mdi.Size1; k++)
            {
                for (int j = 0; j < mdi.Size2; j++)
                {
                    Console.WriteLine("{0,4}", mdi[k, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }



        // IndexerPerson  test



        //IndexerPerson person = new IndexerPerson();
        //Console.WriteLine("Array s 12th element: " + person[12]);

        //person[2] = "Michael";


        //for (int i = 0; i < person.ArrayLenght; i++)
        //{
        //    Console.WriteLine("Array' s {0} . elemen is {1}  " , i , person[i]);
        //}




    }
}

