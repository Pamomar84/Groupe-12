﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class OTPCodes
    {
       
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        public Utilisateurs UtOTP { get; set; }
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }

    }
}
