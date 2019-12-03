using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /*Şikayetler listesini şikayet sahibi ve firma adı ile birlikte bir listeye atmak için
    için bir sınıf yaptık*/
    public class Complaint
    {
            
            public string Title { get; set; }
            public string Description { get; set; }
            public string Detail { get; set; }
            public string FirmName { get; set; }
            public string UserName { get; set; }            
            public string UserSurName { get; set; }
            
        
    }
}
