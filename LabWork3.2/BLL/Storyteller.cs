using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ExceptionClass;

namespace BLL
{
    [Serializable]
    public class Storyteller : Human
    {
        public string StoryTellLevel { get; set; }
        public string StoryTellerInfo()
        {
            string info = "Ім'я та прізвище розповідача : " + Name + " " + Surname + "\nСтать розповідача: " + Sex +
                "\nІдентифікаційний код: " + IdentificationCode + "\nНавички розказування історій: " + StoryTellLevel +
                "\nЧи вміє готувати:" + Coocking;
            return info;
        }
    }
}
