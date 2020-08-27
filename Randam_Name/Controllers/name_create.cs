using System;
using System.Linq;
using System.Text;

namespace Randam_Name.Controllers
{
    public class name_create
    {
        public string output_name(string format_type, int name_length)
        {
            string hiragana      = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよわをん";
            string katakana      = "アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨワヲン";
            string small_alfabet = "abcdefghijklmnopqrstuvwxyz";
            string big_alfabet   = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            StringBuilder result = new StringBuilder();
            Random rand = new Random();

            switch (format_type)
            {
                case "hira":
                    for (var i = 0; i < name_length; i++) 
                    {
                        result.Append(hiragana.ElementAt(rand.Next(hiragana.Count())));
                    }

                    return result.ToString();

                case "kata":
                    for (var i = 0; i < name_length; i++)
                    {
                        result.Append(katakana.ElementAt(rand.Next(katakana.Count())));
                    }

                    return result.ToString();

                case "big":
                    for (var i = 0; i < name_length; i++)
                    {
                        result.Append(big_alfabet.ElementAt(rand.Next(big_alfabet.Count())));
                    }
                    
                    return result.ToString();

                case "small":
                    for (var i = 0; i < name_length; i++)
                    {
                        result.Append(small_alfabet.ElementAt(rand.Next(small_alfabet.Count())));
                    }

                    return result.ToString();

                case "all":
                    string all_string = hiragana + katakana + small_alfabet + big_alfabet;
                    for (var i = 0; i < name_length; i++)
                    {
                        result.Append(all_string.ElementAt(rand.Next(all_string.Count())));
                    }

                    return result.ToString();

                default:
                    result.Append("あアAa").ToString();
                    return result.ToString();
                   
            }

        }
    }
}
