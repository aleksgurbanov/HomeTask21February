using System;
using System.Collections.Generic;
using System.Text;

namespace bookclas
{
    class BookClass
    {
       

     
        public string  _name;
        public string Name
        {
            get { return _name; }
            set 
            {
            


                step1:
                if (value.Length < 3)
                {
                    Console.WriteLine("kitab adi 3 herfden boyuk olmalidir.Yeniden daxil et");
                    value = Console.ReadLine();
                    goto step1;
                }
                _name = value;
            }
        }
        private int _pagecount;
        public int PageCount
        {
            get { return _pagecount; }
            set
             {  
               

                
                    if (_pagecount < 10)
                    {
                        Console.WriteLine("10 sehifeden ashaqi ola bilmez");
                     
                    

                    }
                    else Console.WriteLine("yeniden daxil et");
                
                
               
                    
                    

                

            }


        }
        public BookClass(string name)
        {
            Name = name;
            

        }

        public string  Kitablar(int PageCount, string Name, string [] kitablar)
        {

            return $"{Name} \n {PageCount}";


        }

        public BookClass(int pagecount)
        {
            PageCount = pagecount;

        }


    }
}
