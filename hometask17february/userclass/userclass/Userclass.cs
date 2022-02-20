using System;
using System.Collections.Generic;
using System.Text;

namespace userclass
{
    class Userclass
    {
        private string _username;

        public string Istifadeci
        {
            get
            {

                return _username;
            }
            set
            {
            step1:
                if (value.Length < 8)
                {
                    Console.WriteLine("daxil etdiyiniz istifadeci adi kriteriyalari qarshilamir.Yeniden duzgun shekilde daxil edin");
                    value = Console.ReadLine();
                    goto step1;

                }
                
                _username = value;


            }

        }
        private string _parol;
        public string Parol
        {
            get { return _parol; }
            set
            { step2:
                
                
                bool check = true;
                while (check)
                {
                    bool boyukherf = false;

                    bool kicikherf = false;

                    bool reqem = false;
                    
                    if (value.Length >= 8)
                    {
                        foreach (char item in value)
                        {
                            if (char.IsDigit(item))
                            {
                                reqem = true;
                            }
                            else if (char.IsLower(item))
                            {
                                kicikherf = true;


                            }
                            else if (char.IsUpper(item))
                            {
                                boyukherf = true;

                            }
                            if (boyukherf && kicikherf && reqem)
                            {
                                _parol = value;
                                check = false;
                                break;


                            }
                        }
                    }
                    
                    if (!boyukherf || !kicikherf || !reqem)
                    {
                        Console.WriteLine("qoydugunuz shifre parol standartlarimizi qarshilamir.parolunuzu yeniden daxil edin");
                        value = Console.ReadLine();
                        goto step2;

                    }

                }






            }
        }



            public Userclass (string username)
             
              {
                   Istifadeci = username;
                  
              }


        }
       

       


    }


